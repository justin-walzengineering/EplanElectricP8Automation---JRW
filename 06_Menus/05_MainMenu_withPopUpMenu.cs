using System.Windows.Forms;
using Eplan.EplApi.Scripting;

// Goal:
// Create a new menu item and allow user to run an action from menu item
// Also allows user to view sub menus
// Menu item is located after Help at [Menu 2]

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

		uint MenuID = new uint (); // Menu ID from the newly created menu
        MenuID = oMenu.AddMainMenu (// Set the menu ID of the object
            "Menu 2", // Name: Menu
            "Help", // next to the menu item
            "Main menu with a menu item", // Name: Menu item
            "MenuAction", // Name: Action
            "Status text", // status text
            1 // 1 = after menu item, 0 = before menu item
            );

        oMenu.AddPopupMenuItem (
            "Popup menu with ...", // Name: Menu
            "Sub-item", // name: menu item
            "MenuAction", // Name: Action
            "Status text", // status text
            MenuID, // Menu ID
            1, // 1 = after menu item, 0 = before menu item
            true, // Show separator in front of it
            false // show separator behind it
            );

        return;
    }
}




