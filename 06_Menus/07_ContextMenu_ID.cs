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
    [DeclareRegister]
    public void Register()
    {
        Eplan.EplApi.Base.Settings oSettings =
            new Eplan.EplApi.Base.Settings();

        oSettings.SetBoolSetting(
            "USER.EnfMVC.ContextMenuSetting.ShowIdentifier",
            true,
            0
            );

        MessageBox.Show("Context menu ID: visible");

        return;
    }

    [DeclareUnregister]
    public void UnRegister()
    {
        Eplan.EplApi.Base.Settings oSettings =
            new Eplan.EplApi.Base.Settings();

        oSettings.SetBoolSetting(
            "USER.EnfMVC.ContextMenuSetting.ShowIdentifier",
            false,
            0
            );

        MessageBox.Show("Context menu ID: invisible");

        return;
    }
}



