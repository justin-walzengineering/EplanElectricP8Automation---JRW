using System.Windows.Forms;
using Eplan.EplApi.Scripting;

// Goal:
// Create a new menu item and allow user to run an action from menu item
// Menu item is located at [Utilities] > [Menu item at the end of utilities]

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

		 // Name: Menu item
		 // Name: Action
		 
        oMenu.AddMenuItem("Menu item at the end of utilities", "MenuAction" );

        return;
    }
}




