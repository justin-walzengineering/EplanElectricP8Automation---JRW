using System.Windows.Forms;
using Eplan.EplApi.Scripting;

// Goal:
// Display message box with information after closing a project
// This will display after closing a project

// Load script in Eplan using [Utilities]>[Scripts]>[Load]
// Then choose the file from the file location. 
// The file will be a .cs extension.

public class Class
{
    [DeclareEventHandler("onActionStart.String.XPrjActionProjectClose")]
    public void Function()
    {
        MessageBox.Show("I can do scripts!");

        return;
    }
}



