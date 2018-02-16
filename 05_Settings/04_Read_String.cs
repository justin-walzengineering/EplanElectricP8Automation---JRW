using System.Windows.Forms;
using Eplan.EplApi.Scripting;

// Goal:
// Get user name from user data and display in message box
// This can be found in [Options]>[Settings]>[User]>[Display]>[User code / address] ~ {Name:}

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

        string strName = oSettings.GetStringSetting("USER.TrDMProject.UserData.Longname", 0);

        MessageBox.Show("Hello " + strName + "!");

        return;
    }
}