using System.Windows.Forms;
using Eplan.EplApi.Scripting;

// Goal:
// Display message box with information after loading a script
// First message will display after loading script
// Second message will display after unloading script

// Load script in Eplan using [Utilities]>[Scripts]>[Load]
// Then choose the file from the file location. 
// The file will be a .cs extension.

public class Class
{
    [DeclareRegister]
    public void Register()
    {
        MessageBox.Show("Script loaded.");

        return;
    }

    [DeclareUnregister]
    public void UnRegister()
    {
        MessageBox.Show("Script unloaded.");

        return;
    }
}



