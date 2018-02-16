using System.IO;
using System.Windows.Forms;
using Eplan.EplApi.Scripting;

// Goal:
// Check to see if a file exists in a certain location
// If file does not exist, it will create it. 
// If folder location doesn't exist, an error will be shown. 

// Run script in Eplan using [Utilities]>[Scripts]>[Run]
// Then choose the file from the file location. 
// The file will be a .cs extension.

public class Class
{
    [Start]
    public void Function()
    {
        string strFilename = @"C:\test\test.txt";

        if (File.Exists(strFilename))
        {
            MessageBox.Show("File already exists.");
        }
        else
        {
            File.Create(strFilename);
            MessageBox.Show("File created.");
        }

        return;
    }
}



