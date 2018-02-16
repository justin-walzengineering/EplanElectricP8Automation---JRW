using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

// Goal:
// Sets certain project properties

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

        acc.AddParameter("PropertyId", "10013");
        acc.AddParameter("PropertyIndex", "0");
        acc.AddParameter("PropertyValue", "23542");

        oCLI.Execute("XEsSetProjectPropertyAction", acc);

        MessageBox.Show("Action performed.");

        return;
    }
}
