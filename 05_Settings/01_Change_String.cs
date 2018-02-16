using System.Windows.Forms;
using Eplan.EplApi.Scripting;

// Goal:
// Change Code value in user settings
// This can be found in [Options]>[Settings]>[User]>[Display]>[User code / address] ~ {Code}

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

        oSettings.SetStringSetting("USER.TrDMProject.UserData.Identification", "TEST", 0);

        MessageBox.Show("Setting has been set.");

        return;
    }

}