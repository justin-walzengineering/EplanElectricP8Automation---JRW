using System;
using System.Diagnostics; // Additionally
using System.Windows.Forms;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

// Goal:
// Place multiple process functions into a menu item
// I couldn't get any of the processes to run effectively

// Load script in Eplan using [Utilities]>[Scripts]>[Load]
// Then choose the file from the file location. 
// The file will be a .cs extension.

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
                "Error",
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

        uint MenuID = new uint(); // Menu ID from the newly created menu

        MenuID = oMenu.AddMainMenu(
			"External Programs", // Name: Menu
            "Help", // next to the menu item
            "Calculator", // Name: Menu item
            "StartProcess / PROCESS: calc / PARAMETER: ''", // Name: Action
            "Open calculator ...", // Status text
            1 // 1 = Behind menu item, 0 = Before menu item
            );

        MenuID = oMenu.AddMenuItem(
			"Open project folder", // Name: Menu item
            "StartProcess / PROCESS: explorer / PARAMETER:"
                + quote + strProjectpath + quote, // Name: Action
            "Open project folder in Explorer ...", // Status text
            MenuID, // Menu ID: Insert / Window Macro ...
            1, // 1 = Behind menu item, 0 = Before menu item
            false, // show separator in front of it
            false // show separator behind it
            );

        MenuID = oMenu.AddMenuItem(
			"Character Map", // Name: Menu item
            "StartProcess / PROCESS: charmap / PARAMETER: ''", // Name: Action
            "Open character table ...", // Status text
            MenuID, // Menu ID: Insert / Window Macro ...
            1, // 1 = Behind menu item, 0 = Before menu item
            false, // show separator in front of it
            false // show separator behind it
            );

        MenuID = oMenu.AddMenuItem(
			"Open PDF", // Name: Menu item
            "StartProcess / PROCESS:"
                + quote + strPdfExample + quote
                + "/ PARAMETER: ''", // Name: Action
            "Open example PDF ...", // Status text
            MenuID, // Menu ID: Insert / Window Macro ...
            1, // 1 = Behind menu item, 0 = Before menu item
            false, // show separator in front of it
            false // show separator behind it
            );

        return;

    }
}

