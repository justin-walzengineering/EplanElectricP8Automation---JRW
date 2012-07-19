using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class Class
{
    [Start]
    public void Function()
    {
        string strProjectpath =
            PathMap.SubstitutePath("$(PROJECTPATH)") + @"\";

        CommandLineInterpreter oCLI = new CommandLineInterpreter();
        ActionCallingContext acc = new ActionCallingContext();

        acc.AddParameter("TYPE", "EXPORT");
        acc.AddParameter("EXPORTFILE", strProjectpath + "Partlist.txt");
        acc.AddParameter("FORMAT", "XPalCSVConverter");

        oCLI.Execute("partslist", acc);

        MessageBox.Show("Action ausgeführt.");

        return;
    }
}
