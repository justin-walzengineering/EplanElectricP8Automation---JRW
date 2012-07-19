using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

public class Class
{
    [Start]
    public void Function()
    {
        CommandLineInterpreter oCLI = new CommandLineInterpreter();
        ActionCallingContext acc = new ActionCallingContext();

        acc.AddParameter("Name", "XGedIaFormatText");
        acc.AddParameter("height", "20");

        oCLI.Execute("XGedStartInteractionAction", acc);

        return;
    }
}



