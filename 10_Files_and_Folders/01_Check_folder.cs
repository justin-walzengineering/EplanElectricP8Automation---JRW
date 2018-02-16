using System.IO;
using System.Windows.Forms;
using Eplan.EplApi.Scripting;

// Goal:
// Check to see if a folder exists in a certain location
// If folder does not exist, it will create it. 

// Run script in Eplan using [Utilities]>[Scripts]>[Run]
// Then choose the file from the file location. 
// The file will be a .cs extension.

public class Class
{
    [Start]
    public void Function()
    {
        string strDirName = @"C:\test\";

        if (Directory.Exists(strDirName))
        {
            MessageBox.Show("Folder already exists.");
        }
        else
        {
            Directory.CreateDirectory(strDirName);
            MessageBox.Show("Folder created.");
        }

        return;
    }
}



