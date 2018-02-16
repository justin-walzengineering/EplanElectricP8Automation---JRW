using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

// Goal:
// Not sure what this one does. Could not locate menu to run action.

// Load script in Eplan using [Utilities]>[Scripts]>[Load]
// Then choose the file from the file location. 
// The file will be a .cs extension.

class Class
{
    [DeclareAction("GetNumberOfPages")]
    public void Function()
    {
        CommandLineInterpreter oCLI = new CommandLineInterpreter();
        ActionCallingContext acc = new ActionCallingContext();

        string strPages = string.Empty;

        acc.AddParameter("TYPE", "PAGES");

        oCLI.Execute("selectionset", acc);

        acc.GetParameter("PAGES", ref strPages);

        string[] strPagesCount = strPages.Split(';');
        int intPagesCount = strPagesCount.Length;

        string strProjectname = PathMap.SubstitutePath("$(PROJECTNAME)");

        MessageBox.Show("Number of marked pages:\n"
            + "►►► " + intPagesCount.ToString() + " ◄◄◄",
            "Marked pages [" + strProjectname + "]",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

        return;
    }

    [DeclareMenu]
    public void MenuFunction()
    {
        Eplan.EplApi.Gui.Menu oMenu = new Eplan.EplApi.Gui.Menu();

        oMenu.AddMenuItem(
            "Determine page number...", // Name: Menu Item
            "GetNumberOfPages", // Name: Action
            "Output number of marked pages", // Status text
            35392, // Menu ID: Menu> Page
            1, // 1 = Behind Menu Item, 0 = In front Menu Item
            true, // Show separator in front of it
            false // Show separator behind it
            );

        return;
    }
}