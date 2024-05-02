using System;
using Itmo.ObjectOrientedProgramming.Lab3.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Service;
using Itmo.ObjectOrientedProgramming.Lab3.Users;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class Test
{
    private const string MessageBody = "A?";
    private const string MessageHeading = "A??";
    private const string ResultOfMessenger = "Messenger: A?";
    private const ImportanceLevel Level = ImportanceLevel.LevelThird;

    [Fact]
    public void TestMessageRemainsUnread()
    {
        var myMessage = new Message(MessageHeading, MessageBody, Level);
        var userAddressee = new AddresseeUser(new User());

        userAddressee.SendMessage(myMessage);
        Assert.Equal(Status.Unread, userAddressee.CheckMessages[0].Status.MyStatus);
    }

    [Fact]
    public void TestChangeStatusSuccess()
    {
        var myMessage = new Message(MessageHeading, MessageBody, Level);
        var userAddressee = new AddresseeUser(new User());

        userAddressee.SendMessage(myMessage);
        userAddressee.CheckMessages[0].Status.ChangeStatusToRead();
        Assert.Equal(Status.Read, userAddressee.CheckMessages[0].Status.MyStatus);
    }

    [Fact]
    public void TestChangeStatusFail()
    {
        var myMessage = new Message(MessageHeading, MessageBody, Level);
        var userAddressee = new AddresseeUser(new User());

        userAddressee.SendMessage(myMessage);
        userAddressee.CheckMessages[0].Status.ChangeStatusToRead();
        Action throwingAction = () =>
        {
            userAddressee.CheckMessages[0].Status.ChangeStatusToRead();
        };
        Assert.Throws<InvalidOperationException>(throwingAction);
    }

    [Fact]
    public void TestMessageDidNotReachTheAddressee()
    {
        var myMessage = new Message(MessageHeading, MessageBody, Level);
        var userAddressee = new AddresseeUser(new User());

        var mockFilter = new MockFilter();
        mockFilter.SetAddressee(userAddressee);
        bool result = mockFilter.SendMessage(myMessage);
        Assert.False(result);
    }

    [Fact]
    public void TestLoggingMessage()
    {
        var myMessage = new Message(MessageHeading, MessageBody, Level);
        var userAddressee = new AddresseeUser(new User());

        var mockLogger = new MockLogger();
        mockLogger.SetAddressee(userAddressee);

        string? myLog = mockLogger.SendMessage(myMessage);
        Assert.Equal(MessageBody, myLog);
    }

    [Fact]
    public void TestMessenger()
    {
        var myMessage = new Message(MessageHeading, MessageBody, Level);
        var myMessenger = new MockMessenger();

        string resultOfMessaging = myMessenger.SendMessage(myMessage);
        Assert.Equal(ResultOfMessenger, resultOfMessaging);
    }
}