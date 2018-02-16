using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

// Goal:
// Not sure what this does. Looks like it creates a project.

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

        acc.AddParameter("Project", @"C:\Projekte\Beispielprojekt.elk");
        acc.AddParameter("Action", "reports");
        acc.AddParameter("NOCLOSE", "1");

        oCLI.Execute("ProjectAction", acc);

        MessageBox.Show("Action performed.");

        return;
    }
}
