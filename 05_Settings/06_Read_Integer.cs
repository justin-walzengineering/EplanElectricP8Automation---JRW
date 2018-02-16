using System.Windows.Forms;
using Eplan.EplApi.Scripting;

// Goal:
// Displays value of the preview window
// I'm not sure what this is displaying, nor how to change or modify the value

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

        int intSetting = oSettings.GetNumericSetting("USER.MF.PREVIEW.MINCOLWIDTH", 0);

        MessageBox.Show("Minimum width of the tiles in the preview: " + intSetting.ToString());

        return;
    }

}