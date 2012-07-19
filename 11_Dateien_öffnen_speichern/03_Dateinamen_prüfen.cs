using System.Windows.Forms;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class Class
{
    [Start]
    public void Function()
    {
        string strChars = @"[\\/:*?""<>|]";

        MessageBox.Show("Diese Zeichen werden umgewandelt:\n" + strChars,
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

