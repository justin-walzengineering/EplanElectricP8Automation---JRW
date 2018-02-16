using System.IO;
using System.Windows.Forms;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

// Goal:
// Open a file in a user defined location

// Run script in Eplan using [Utilities]>[Scripts]>[Run]
// Then choose the file from the file location. 
// The file will be a .cs extension.

public class Class
{
    [Start]
    public void Function()
    {
        string strProjectpath =
            PathMap.SubstitutePath("$(PROJECTPATH)") + @"\";
        string strFilename = "Test dates";

        OpenFileDialog ofd = new OpenFileDialog();
        ofd.DefaultExt = "txt";
        ofd.FileName = strFilename;
        ofd.Filter = "Test dates (*Test dates*.txt)"
            + "|*Test dates*.txt|All files (*.*)|*.*";
        ofd.InitialDirectory = strProjectpath;
        ofd.Title = "Test dates choose:";
        ofd.ValidateNames = true;

        if (ofd.ShowDialog() == DialogResult.OK)
        {
            strFilename = ofd.FileName;
            MessageBox.Show(
                "The location was successfully submitted:\n"
                + strFilename,
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        return;
    }
}

