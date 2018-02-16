using System.IO;
using System.Windows.Forms;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

// Goal:
// Create a file in a user defined location

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

        SaveFileDialog sfd = new SaveFileDialog();
        sfd.DefaultExt = "txt";
        sfd.FileName = strFilename;
        sfd.Filter = "Text file (*.txt)|*.txt";
        sfd.InitialDirectory = strProjectpath;
        sfd.Title = "Select location for test dates:";
        sfd.ValidateNames = true;

        if (sfd.ShowDialog() == DialogResult.OK)
        {
            File.Create(sfd.FileName);
            MessageBox.Show(
                "File was saved successfully:\n" + sfd.FileName,
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        return;
    }
}

