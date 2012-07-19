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

        oMenu.AddMenuItem(
            "Bestehendes Menü erweitern", // Name: Menüpunkt
            "MenuAction", // Name: Action
            "Statustext", // Statustext
            37024, // Menü-ID: Einfügen/Fenstermakro...
            1, // 1 = hinter Menüpunkt, 0 = vor Menüpunkt
            false, // Separator davor anzeigen
            false // Separator dahinter anzeigen
            );

        return;
    }
}




