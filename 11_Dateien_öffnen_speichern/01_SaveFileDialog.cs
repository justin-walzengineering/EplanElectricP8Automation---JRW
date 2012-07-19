using System.IO;
using System.Windows.Forms;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class Class
{
    [Start]
    public void Function()
    {
        string strProjectpath =
            PathMap.SubstitutePath("$(PROJECTPATH)") + @"\";
        string strFilename = "Testdatei";

        SaveFileDialog sfd = new SaveFileDialog();
        sfd.DefaultExt = "txt";
        sfd.FileName = strFilename;
        sfd.Filter = "Textdatei (*.txt)|*.txt";
        sfd.InitialDirectory = strProjectpath;
        sfd.Title = "Speicherort für Testdatei wählen:";
        sfd.ValidateNames = true;

        if (sfd.ShowDialog() == DialogResult.OK)
        {
            File.Create(sfd.FileName);
            MessageBox.Show(
                "Datei wurde erfolgreich gespeichert:\n" + sfd.FileName,
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        return;
    }
}

