using System.Windows.Forms;
using Eplan.EplApi.Scripting;

// Goal:
// Not sure what this setting is for.

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

        oSettings.SetNumericSetting("USER.SYSTEM.GUI.LAST_PROJECTS_COUNT", 11, 0);

        MessageBox.Show("Setting has been set.");

        return;
    }

}