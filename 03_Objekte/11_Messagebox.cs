using System.Windows.Forms;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class Class
{
    [Start]
    public void Function()
    {
        string strProjectname = PathMap.SubstitutePath("$(PROJECTNAME)");

        MessageBox.Show("Text", strProjectname);

        MessageBox.Show(
            "Text",
            strProjectname,
            MessageBoxButtons.YesNo
            );

        MessageBox.Show(
            "Text",
            strProjectname,
            MessageBoxButtons.AbortRetryIgnore,
            MessageBoxIcon.Information
            );

        return;
    }
}



