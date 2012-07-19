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
        Eplan.EplApi.Gui.ContextMenu oMenu =
            new Eplan.EplApi.Gui.ContextMenu();

        Eplan.EplApi.Gui.ContextMenuLocation oLocation =
            new Eplan.EplApi.Gui.ContextMenuLocation(
                "GedEditGuiText",
                "1002"
                );

        oMenu.AddMenuItem(
            oLocation,
            "Menüpunkt in Kontextmenü",
            "MenuAction",
            true,
            false
            );

        return;
    }
}




