using System.Windows.Forms;
using Eplan.EplApi.Scripting;

// Goal:
// Create a new menu item and allow user to run an action from menu item
// I cannot find the location of this menu creation

// Load script in Eplan using [Utilities]>[Scripts]>[Load]
// Then choose the file from the file location. 
// The file will be a .cs extension.

public class Class
{

    [DeclareAction("MenuAction")]
    public void ActionFunction()
    {
        MessageBox.Show("Action was executed!");

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
			"Menu item in context menu",
            "MenuAction",
            true,
            false
            );

        return;
    }
}




