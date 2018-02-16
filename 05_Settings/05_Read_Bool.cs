using System.Windows.Forms;
using Eplan.EplApi.Scripting;

// Goal:
// Checks whether the "Use logon name for changes" is on or off
// This can be found in [Options]>[Settings]>[User]>[Display]>[User code / address] ~ {Use logon name for changes}

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

        bool bolSetting = oSettings.GetBoolSetting("USER.XUserSettingsGui.UseLoginName",0);

        if (bolSetting)
        {
            MessageBox.Show("Setting is activated.");
        }
        else
        {
            MessageBox.Show("Setting is deactivated.");
        }

        return;
    }
}