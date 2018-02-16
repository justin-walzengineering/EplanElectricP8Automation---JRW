using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

// Goal:
// Compress project

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

        acc.AddParameter("CONFIGSCHEME", "Standard");
        acc.AddParameter("FILTERSCHEME", "Allpolig");

        oCLI.Execute("compress", acc);

        MessageBox.Show("Action performed.");

        return;
    }
}
