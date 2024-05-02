using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Computers;

namespace Itmo.ObjectOrientedProgramming.Lab2.Service;

public class Configurator
{
    private bool _result = true;
    private IList<Result> _resultBuildChecklist = new List<Result> { };

    public Result ResultOfBuilding()
    {
        return _result == true ? Result.Success : Result.Failure;
    }

    public void GetChecklist(Computer computer)
    {
        var buildChecklist = new List<Result>();

        if (computer.GetComputerCase != null &&
            computer.GetMotherboard != null &&
            computer.GetComputerCase.SupportedMotherboardFormFactors.Contains(computer.GetMotherboard.FormFactor))
        {
            int numberOfPciEConnection = 1;
            int numberOfSataConnection = 0;
            if (computer.GetSsd != null && computer.GetSsd.ConnectionOption == ConnectionOptions.Sata)
            {
                numberOfPciEConnection -= 1;
                numberOfSataConnection += 1;
            }

            if (computer.GetVideocard != null) numberOfPciEConnection += 1;
            if (computer.GetWiFiAdapter != null) numberOfPciEConnection += 1;
            if (computer.GetSsd != null) numberOfPciEConnection += 1;

            if (numberOfPciEConnection <= computer.GetMotherboard.NumberOfPciLines &&
                numberOfSataConnection <= computer.GetMotherboard.NumberOfSataPorts)
            {
                buildChecklist.Add(Result.SuccessMotherboardIsCompatibleWithCase);
            }
            else
            {
                buildChecklist.Add(Result.FailureTheMotherboardIsNotCompatibleWithTheCase);
                _result = false;
            }
        }
        else
        {
            buildChecklist.Add(Result.FailureTheMotherboardIsNotCompatibleWithTheCase);
            _result = false;
        }

        if (computer.GetMotherboard != null &&
            computer.GetCpu != null &&
            computer.GetMotherboard.Soket == computer.GetCpu.Soket)
        {
            buildChecklist.Add(Result.SuccessProcessorConnected);
        }
        else
        {
            buildChecklist.Add(Result.FailureProcessorCannotBeConnected);
            _result = false;
        }

        if (computer.GetCpu != null &&
            computer.GetComputerCase != null &&
            computer.GetProcessorCoolingSystem != null &&
            computer.GetCpu.Tdp < computer.GetProcessorCoolingSystem.MaxTdp &&
            computer.GetComputerCase.MaxDimensionOfVideocard >= computer.GetProcessorCoolingSystem.Dimension)
        {
            buildChecklist.Add(Result.SuccessCoolingSystemConnected);
        }
        else if (computer.GetCpu != null &&
                 computer.GetProcessorCoolingSystem != null &&
                 computer.GetComputerCase != null &&
                 computer.GetCpu.Tdp > computer.GetProcessorCoolingSystem.MaxTdp &&
                 computer.GetComputerCase.MaxDimensionOfVideocard >= computer.GetProcessorCoolingSystem.Dimension)
        {
            buildChecklist.Add(Result.WarningWeakCoolingSystemDisclaimerOfWarranty);
        }
        else
        {
            buildChecklist.Add(Result.FailureCoolingSystemCannotBeConnected);
            _result = false;
        }

        if (computer.GetRam != null &&
            computer.GetMotherboard != null &&
            computer.GetRam.DdrStandart == computer.GetMotherboard.DdrStandart)
        {
            buildChecklist.Add(Result.SuccessRamConnected);
        }
        else
        {
            buildChecklist.Add(Result.FailureRamCannotBeConnected);
            _result = false;
        }

        int consumptionPower = 0;
        if (computer.GetSsd != null) consumptionPower += computer.GetSsd.PowerConsumption;
        if (computer.GetHdd != null) consumptionPower += computer.GetHdd.PowerConsumption;
        if (computer.GetWiFiAdapter != null) consumptionPower += computer.GetWiFiAdapter.PowerConsumption;

        if (computer.GetVideocard != null)
        {
            consumptionPower += computer.GetVideocard.PowerConsumption;
            if (computer.GetComputerCase != null &&
                computer.GetComputerCase.MaxDimensionOfVideocard >= computer.GetVideocard.Dimension &&
                computer.GetCpu != null && computer.GetCpu.PresenceOfBuildInVideoCore == false)
            {
                buildChecklist.Add(Result.SuccessVideocardConnected);
            }
            else
            {
                buildChecklist.Add(Result.FailureVideocardCannotBeConnected);
                _result = false;
            }
        }

        if (computer.GetXmpProfile != null)
        {
            if (computer.GetMotherboard?.UsedChipset?.XmpProfile == true)
            {
                buildChecklist.Add(Result.SuccessXmpProfileConnected);
            }
            else
            {
                buildChecklist.Add(Result.FailureXmpProfileCannotBeConnected);
                _result = false;
            }
        }

        if (computer.GetPsu != null && computer.GetCpu != null && computer.GetRam != null && computer.GetPsu.PeakLoad > (computer.GetCpu.PowerConsumption + computer.GetRam.PowerConsumption + consumptionPower)) buildChecklist.Add(Result.SuccessPsuConnected);
        else buildChecklist.Add(Result.WarningInsufficientPsuPower);

        _resultBuildChecklist = buildChecklist;
    }
}