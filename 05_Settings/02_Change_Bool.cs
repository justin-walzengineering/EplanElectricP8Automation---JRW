using System.Windows.Forms;
using Eplan.EplApi.Scripting;

// Goal:
// After you have executed the script, you first have to restart EPLAN. 
// In the context menu of the Settings dialog, you will then have the Copy path for setting to Clipboard option. 
// Execute the menu item for a setting and copy the name to the ClipBoard. 

// Run script in Eplan using [Utilities]>[Scripts]>[Run]
// Then choose the file from the file location. 
// The file will be a .cs extension.

public class Class
{
    [Start]
    public void Function()
    {
        Eplan.EplApi.Base.Settings oSettings =
            new Eplan.EplApi.Base.Settings();

        oSettings.SetBoolSetting("USER.EnfMVC.ContextMenuSetting.ShowExtended", true, 0);

        MessageBox.Show("Setting has been activated. EPLAN restart required.");

        return;
    }

}