using System.IO;
using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class Class
{
    [Start]
    public void Function()
    {
        string strFilename = @"C:\test\test.txt";

        if (File.Exists(strFilename))
        {
            MessageBox.Show("Datei schon vorhanden.");
        }
        else
        {
            File.Create(strFilename);
            MessageBox.Show("Datei erstellt.");
        }

        return;
    }
}



