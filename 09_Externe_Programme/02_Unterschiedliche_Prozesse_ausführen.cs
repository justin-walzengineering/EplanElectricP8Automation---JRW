using System;
using System.Diagnostics; // Zusätzlich
using System.Windows.Forms;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class Class
{
    [DeclareAction("StartProcess")]
    public void Function(string PROCESS, string PARAMETER)
    {
        try
        {
            Process.Start(PROCESS, PARAMETER);
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Fehler",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
        }

        return;
    }

    [DeclareMenu]
    public void MenuFunction()
    {
        Eplan.EplApi.Gui.Menu oMenu = new Eplan.EplApi.Gui.Menu();

        string strProjectpath = PathMap.SubstitutePath("$(PROJECTPATH)");
        string strPdfExample = @"C:\test\test.pdf";
        string quote = "\"";

        uint MenuID = new uint(); // Menü-ID vom neu erzeugten Menü

        MenuID = oMenu.AddMainMenu(
            "Externe Programme", // Name: Menü
            "Hilfe", // neben Menüpunkt
            "Taschenrechner", // Name: Menüpunkt
            "StartProcess /PROCESS:calc /PARAMETER:''", // Name: Action
            "Taschenrechner öffnen...", // Statustext
            1 // 1 = Hinter Menüpunkt, 0 = Vor Menüpunkt
            );

        MenuID = oMenu.AddMenuItem(
            "Projektordner öffnen", // Name: Menüpunkt
            "StartProcess /PROCESS:explorer /PARAMETER:"
                + quote + strProjectpath + quote, // Name: Action
            "Projektordner im Explorer öffnen...", // Statustext
            MenuID, // Menü-ID: Einfügen/Fenstermakro...
            1, // 1 = Hinter Menüpunkt, 0 = Vor Menüpunkt
            false, // Separator davor anzeigen
            false // Separator dahinter anzeigen
            );

        MenuID = oMenu.AddMenuItem(
            "Zeichentabelle", // Name: Menüpunkt
            "StartProcess /PROCESS:charmap /PARAMETER:''", // Name: Action
            "Zeichentabelle öffnen...", // Statustext
            MenuID, // Menü-ID: Einfügen/Fenstermakro...
            1, // 1 = Hinter Menüpunkt, 0 = Vor Menüpunkt
            false, // Separator davor anzeigen
            false // Separator dahinter anzeigen
            );

        MenuID = oMenu.AddMenuItem(
            "PDF öffnen", // Name: Menüpunkt
            "StartProcess /PROCESS:"
                + quote + strPdfExample + quote
                + " /PARAMETER:''", // Name: Action
            "Beispiel PDF öffnen...", // Statustext
            MenuID, // Menü-ID: Einfügen/Fenstermakro...
            1, // 1 = Hinter Menüpunkt, 0 = Vor Menüpunkt
            false, // Separator davor anzeigen
            false // Separator dahinter anzeigen
            );

        return;

    }
}

