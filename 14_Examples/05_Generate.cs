using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

// Goal:
// I'm not sure what this is generating

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

        acc.AddParameter("TYPE", "CABLES");
        acc.AddParameter("CREATIONSCHEME", "Standard");
        acc.AddParameter("NUMBERINGSCHEME", "Standard");
        acc.AddParameter("AUTOSELECTSCHEME", "Standard");
        acc.AddParameter("REGENERATECONNS", "1");
        acc.AddParameter("KEEPOLDNAMES", "1");
        acc.AddParameter("STARTVALUE", "1");
        acc.AddParameter("STEPVALUE", "1");
        acc.AddParameter("ONLYAUTOCABLES", "1");
        acc.AddParameter("REBUILDALLCONNECTIONS", "1");

        oCLI.Execute("generate", acc);

        MessageBox.Show("Action performed.");

        return;
    }
}
