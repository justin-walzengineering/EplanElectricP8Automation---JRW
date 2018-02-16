using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

// Goal:
// Restores a project
// Have to be sure the file location for the script file being called is correct

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

        acc.AddParameter("TYPE", "PROJECT");
        acc.AddParameter("ARCHIVENAME",
            @"C:\Projekte\Beispielprojekt.zw1");
        acc.AddParameter("PROJECTNAME",
            @"C:\Projekte\Beispielprojekt.elk");
        acc.AddParameter("UNPACKPROJECT", "0");
        acc.AddParameter("MODE", "1");
        acc.AddParameter("NOCLOSE", "1");

        oCLI.Execute("restore", acc);

        MessageBox.Show("Action accomplished.");

        return;
    }
}
