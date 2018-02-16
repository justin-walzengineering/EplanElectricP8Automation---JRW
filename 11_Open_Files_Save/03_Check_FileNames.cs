using System.Windows.Forms;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

// Goal:
// I'm not sure what this one does

// Run script in Eplan using [Utilities]>[Scripts]>[Run]
// Then choose the file from the file location. 
// The file will be a .cs extension.

public class Class
{
    [Start]
    public void Function()
    {
        string strChars = @"[\\/:*?""<>|]";

        MessageBox.Show("These characters are converted:\n" + strChars,
            "Information",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

        strChars = AdjustPath(strChars);

        MessageBox.Show(strChars,
            "Information",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

        return;
    }

    private string AdjustPath(string Input)
    {
        return System.Text.RegularExpressions.Regex.Replace(
            Input,
            @"[\\/:*?""<>|]",
            "-");
    }
}

