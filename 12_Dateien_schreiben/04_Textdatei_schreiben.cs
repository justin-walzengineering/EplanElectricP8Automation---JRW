using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class Class
{
    [Start]
    public void Function()
    {
        string filename =
            PathMap.SubstitutePath(@"$(PROJECTPATH)\Testdatei.txt");

        string strContent = "Beispieltext\n";

        StreamWriter swTextfile = new StreamWriter(
            filename,
            true,
            Encoding.Unicode
            );

        swTextfile.Write(strContent);
        swTextfile.Close();

        MessageBox.Show(
            "Textdatei erfolgreich exportiert.",
            "Information",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
            );

        Process.Start(filename);

        return;
    }

}



