using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

class Class
{
    [DeclareAction("GetNumberOfPages")]
    public void Function()
    {
        CommandLineInterpreter oCLI = new CommandLineInterpreter();
        ActionCallingContext acc = new ActionCallingContext();

        string strPages = string.Empty;

        acc.AddParameter("TYPE", "PAGES");

        oCLI.Execute("selectionset", acc);

        acc.GetParameter("PAGES", ref strPages);

        string[] strPagesCount = strPages.Split(';');
        int intPagesCount = strPagesCount.Length;

        string strProjectname = PathMap.SubstitutePath("$(PROJECTNAME)");

        MessageBox.Show("Anzahl markierter Seiten:\n"
            + "►►► " + intPagesCount.ToString() + " ◄◄◄",
            "Markierte Seiten [" + strProjectname + "]",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

        return;
    }

    [DeclareMenu]
    public void MenuFunction()
    {
        Eplan.EplApi.Gui.Menu oMenu = new Eplan.EplApi.Gui.Menu();

        oMenu.AddMenuItem(
            "Seitenzahl ermitteln...", // Name: Menüpunkt
            "GetNumberOfPages", // Name: Action
            "Anzahl der markierten Seiten ausgeben", // Statustext
            35392, // Menü-ID: Menü > Seite
            1, // 1 = hinter Menüpunkt, 0 = vor Menüpunkt
            true, // Separator davor anzeigen
            false // Separator dahinter anzeigen
            );

        return;
    }
}