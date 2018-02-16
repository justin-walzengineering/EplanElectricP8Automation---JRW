using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

// Goal:
// Execute a script inside of another script
// Have to be sure the file location for the script file being called is correct

// Run script in Eplan using [Utilities]>[Scripts]>[Run]
// Then choose the file from the file location. 
// The file will be a .cs extension.

public class Class
{
    [Start]
    public void Function()
    {
        CommandLineInterpreter oCLI = new CommandLineInterpreter();
        ActionCallingContext acc = new ActionCallingContext();

        acc.AddParameter("ScriptFile",
            @"C:\EPLAN Scripting Project\01_Erste_Schritte\01_Start.cs");

        oCLI.Execute("ExecuteScript", acc);

        return;
    }
}
