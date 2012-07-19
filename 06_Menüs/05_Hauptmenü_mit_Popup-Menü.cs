using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class Class
{

    [DeclareAction("MenuAction")]
    public void ActionFunction()
    {
        MessageBox.Show("Action wurde ausgeführt!");

        return;
    }

    [DeclareMenu]
    public void MenuFunction()
    {
        Eplan.EplApi.Gui.Menu oMenu = new Eplan.EplApi.Gui.Menu();

        uint MenuID = new uint(); // Menü-ID vom neu erzeugten Menü
        MenuID = oMenu.AddMainMenu( // Festlegen der Menü-ID des Objekts
            "Menü 2", // Name: Menü
            "Hilfe", // neben Menüpunkt
            "Hauptmenü mit einem Menüpunkt", // Name: Menüpunkt
            "MenuAction", // Name: Action
            "Statustext", // Statustext
            1 // 1 = hinter Menüpunkt, 0 = vor Menüpunkt
            );

        oMenu.AddPopupMenuItem(
            "Popup-Menü mit...", // Name: Menü
            "Unterpunkt", // Name: Menüpunkt
            "MenuAction", // Name: Action
            "Statustext", // Statustext
            MenuID, // Menü-ID
            1, // 1 = hinter Menüpunkt, 0 = vor Menüpunkt
            true, // Separator davor anzeigen
            false // Separator dahinter anzeigen
            );

        return;
    }
}




