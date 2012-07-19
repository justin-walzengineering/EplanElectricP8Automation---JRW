using System.IO;
using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class Class
{
    [Start]
    public void Function()
    {
        string strDirName = @"C:\test\";

        if (Directory.Exists(strDirName))
        {
            MessageBox.Show("Ordner schon vorhanden.");
        }
        else
        {
            Directory.CreateDirectory(strDirName);
            MessageBox.Show("Ordner erstellt.");
        }

        return;
    }
}



