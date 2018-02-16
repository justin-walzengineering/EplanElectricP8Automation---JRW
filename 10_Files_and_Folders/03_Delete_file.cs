using System.IO;
using System.Windows.Forms;
using Eplan.EplApi.Scripting;

// Goal:
// Check to see if a file exists in a certain location
// If file does exist, it will be deleted. 

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
            File.Delete(strFilename);
            MessageBox.Show("File deleted");
        }

        return;
    }
}



