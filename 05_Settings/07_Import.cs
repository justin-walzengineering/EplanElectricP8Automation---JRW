using System.Windows.Forms;
using Eplan.EplApi.Scripting;

// Goal:
// This will import settings into Eplan. 

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

        oSettings.ReadSettings(@"C:\test\test.xml");

        MessageBox.Show("Settings have been imported.");

        return;
    }

}