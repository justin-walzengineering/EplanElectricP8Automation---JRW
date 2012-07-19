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
            File.Delete(strFilename);
            MessageBox.Show("Datei gelöscht");
        }

        return;
    }
}



