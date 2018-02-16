using System.Windows.Forms;
using Eplan.EplApi.Scripting;

// Goal:
// This is to declare an action that when called will run the following code
// Display message box with information
// This is going to be used again in folder 2

// Run script in Eplan using [Utilities]>[Scripts]>[Run]
// Then choose the file from the file location. 
// The file will be a .cs extension.

public class Class
{
    [DeclareAction("Actionname")]
    public void Function()
    {
        MessageBox.Show("I can do scripts!");

        return;
    }
}



