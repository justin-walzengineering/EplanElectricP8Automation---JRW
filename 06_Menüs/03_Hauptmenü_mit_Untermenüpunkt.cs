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

        oMenu.AddMainMenu(
            "Menü 1", // Name: Menü
            "Hilfe", // neben Menüpunkt
            "Hauptmenü mit einem Menüpunkt", // Name: Menüpunkt
            "MenuAction", // Name: Action
            "Statustext", // Statustext
            1 // 1 = hinter Menüpunkt, 0 = vor Menüpunkt
            );

        return;
    }
}




