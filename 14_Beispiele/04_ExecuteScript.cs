using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

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
