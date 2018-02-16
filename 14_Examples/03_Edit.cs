using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

// Goal:
// I'm not sure what this one is doing

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

        acc.AddParameter("PAGENAME", "=+/1000");
        acc.AddParameter("DEVICENAME", "=+-1K1");
        acc.AddParameter("FORMAT", "XDLTxtImporterExporter");

        oCLI.Execute("edit", acc);

        return;
    }
}
