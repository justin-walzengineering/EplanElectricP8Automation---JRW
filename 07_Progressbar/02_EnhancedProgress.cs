using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

// Goal:
// Display a progress bar and show time elapsing. 
// Runs multiple functions

// Run script in Eplan using [Utilities]>[Scripts]>[Run]
// Then choose the file from the file location. 
// The file will be a .cs extension.

public class Class
{
    [Start]
    public void Function()
    {
        CommandLineInterpreter oCLI = new CommandLineInterpreter();

        Progress oProgress = new Progress("EnhancedProgress");
        oProgress.SetAllowCancel(false);
        oProgress.ShowImmediately();

        oProgress.BeginPart(33, "Part 1");
        oCLI.Execute("generate /TYPE:CONNECTIONS");
        oProgress.EndPart();

        oProgress.BeginPart(33, "Part 2");
        oCLI.Execute("reports");
        oProgress.EndPart();

        oProgress.BeginPart(33, "Part 3");
        oCLI.Execute("compress /FILTERSCHEME:Standard");
        oProgress.EndPart();

        oProgress.EndPart(true);

        return;
    }
}



