using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

// Goal:
// Creates a device list and places file in project folder (.edb folder)

// Run script in Eplan using [Utilities]>[Scripts]>[Run]
// Then choose the file from the file location. 
// The file will be a .cs extension.

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
        acc.AddParameter("EXPORTFILE", strProjectpath + "Devicelist.txt");
        acc.AddParameter("FORMAT", "XDLTxtImporterExporter");

        oCLI.Execute("devicelist", acc);

        MessageBox.Show("Action performed.");

        return;
    }
}
