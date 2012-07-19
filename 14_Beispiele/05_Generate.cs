using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

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

        MessageBox.Show("Action ausgeführt.");

        return;
    }
}
