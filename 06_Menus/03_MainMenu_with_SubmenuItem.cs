using System.Windows.Forms;
using Eplan.EplApi.Scripting;

// Goal:
// Create a new menu item and allow user to run an action from menu item
// Menu item is located after Help at [Menu 1] > [Main menu with a menu item]

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

        oMenu.AddMainMenu(
			"Menu 1", // Name: Menu
            "Help", // next to the menu item
            "Main menu with a menu item", // Name: Menu item
            "MenuAction", // Name: Action
            "Status text", // status text
            1 // 1 = after menu item, 0 = before menu item
            );

        return;
    }
}




