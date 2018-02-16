using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;
using System.Threading;
using System.Windows.Forms;

// Goal:
// Display wait cursor style on mouse cursor

// Run script in Eplan using [Utilities]>[Scripts]>[Run]
// Then choose the file from the file location. 
// The file will be a .cs extension.

public class Class
{
    [Start]
    public void Function()
    {
        Cursor.Current = Cursors.AppStarting;
        Thread.Sleep(3000);
        Cursor.Current = Cursors.WaitCursor;
        Thread.Sleep(3000);

        return;
    }
}



