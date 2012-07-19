using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

public class Class
{
    [Start]
    public void Function()
    {
        CommandLineInterpreter oCLI = new CommandLineInterpreter();
        ActionCallingContext acc = new ActionCallingContext();

        acc.AddParameter("PAGENAME", "=+/1");
        acc.AddParameter("DEVICENAME", "=+-1K1");
        acc.AddParameter("FORMAT", "XDLTxtImporterExporter");

        oCLI.Execute("edit", acc);

        return;
    }
}
