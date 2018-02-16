using System;
using System.IO;
using System.Windows.Forms;
using Eplan.EplApi.Scripting;

// Goal:
// Create a file in certain location with a date and time stamp

// Run script in Eplan using [Utilities]>[Scripts]>[Run]
// Then choose the file from the file location. 
// The file will be a .cs extension.

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
        MessageBox.Show("File created.");

        return;
    }
}



