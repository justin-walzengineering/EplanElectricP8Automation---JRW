using System;
using System.IO;
using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class Class
{
    [Start]
    public void Function()
    {
        string strDate = DateTime.Now.ToString("yyyy-MM-dd");
        string strTime = DateTime.Now.ToString("HH-mm-ss");
        string strFilename = @"C:\test\test_"
            + strDate
            + "_"
            + strTime
            + ".txt";

        File.Create(strFilename);
        MessageBox.Show("Datei erstellt.");

        return;
    }
}



