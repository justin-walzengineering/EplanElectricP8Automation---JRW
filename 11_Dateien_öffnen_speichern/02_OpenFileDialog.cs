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

        OpenFileDialog ofd = new OpenFileDialog();
        ofd.DefaultExt = "txt";
        ofd.FileName = strFilename;
        ofd.Filter = "Testdatei (*Testdatei*.txt)"
            + "|*Testdatei*.txt|Alle Dateien (*.*)|*.*";
        ofd.InitialDirectory = strProjectpath;
        ofd.Title = "Testdatei auswählen:";
        ofd.ValidateNames = true;

        if (ofd.ShowDialog() == DialogResult.OK)
        {
            strFilename = ofd.FileName;
            MessageBox.Show(
                "Der Speicherort wurde erfolgreich übergeben:\n"
                + strFilename,
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        return;
    }
}

