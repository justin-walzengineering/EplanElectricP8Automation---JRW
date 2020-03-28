using System.Windows.Forms;
using Eplan.EplApi.Scripting;

// Goal:
// Display message box with information

// Run script in Eplan using [Utilities]>[Scripts]>[Run]
// Then choose the file from the file location. 
// The file will be a .cs extension. 

public class Class
{
    [Start]
    public void Function()
    {
        MessageBox.Show("I can do scripts!"); // Comment
        return;

    }
}



