using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

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

        MessageBox.Show("Action ausgeführt.");

        return;
    }
}
