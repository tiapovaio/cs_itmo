namespace Itmo.ObjectOrientedProgramming.Lab2.Service;

public enum Result
{
    Success,
    SuccessMotherboardIsCompatibleWithCase,
    SuccessProcessorConnected,
    SuccessPsuConnected,
    SuccessCoolingSystemConnected,
    SuccessVideocardConnected,
    SuccessRamConnected,
    SuccessXmpProfileConnected,

    WarningWeakCoolingSystemDisclaimerOfWarranty,
    WarningInsufficientPsuPower,

    Failure,
    FailureTheMotherboardIsNotCompatibleWithTheCase,
    FailureProcessorCannotBeConnected,
    FailureCoolingSystemCannotBeConnected,
    FailureVideocardCannotBeConnected,
    FailureRamCannotBeConnected,
    FailureXmpProfileCannotBeConnected,
}