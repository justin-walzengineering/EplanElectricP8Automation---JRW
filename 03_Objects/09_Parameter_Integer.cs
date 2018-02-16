using System.Windows.Forms;
using Eplan.EplApi.Scripting;

// Goal:
// Create a new action that will be used to ask for a two integers, in which it will use these to calculate and display certain values in a message box

// Load script in Eplan using [Utilities]>[Scripts]>[Load]
// Then choose the file from the file location. 
// The file will be a .cs extension.

public class Class
{
    [DeclareAction("IntParameter")]
    public void Function(int INT1, int INT2)
    {
        int ResultInt = INT1 + INT2;
        MessageBox.Show(INT1.ToString() + " + " + INT2.ToString() + " = " + ResultInt.ToString());

        return;
    }
}



