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
        Eplan.EplApi.Gui.Menu oMenu = new Eplan.EplApi.Gui.Menu();

        oMenu.AddPopupMenuItem(
			"Extend existing menu ...", // Name: Menu
            "with pop-up menu", // Name: Menu item
            "MenuAction", // Name: Action
            "Status text", // status text
            37024, // Menu ID: Insert / Window macro ...
            0, // 1 = behind the menu item, 0 = in front of the menu item
            false, // show separator in front of it
            false // show separator behind it
            );

        return;
    }
}




