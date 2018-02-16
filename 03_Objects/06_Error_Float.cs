using System.Windows.Forms;
using Eplan.EplApi.Scripting;

// Goal:
// Display integers in message box. Shows concept that if you divide float as string it will remove decimal values

// Run script in Eplan using [Utilities]>[Scripts]>[Run]
// Then choose the file from the file location. 
// The file will be a .cs extension.

public class Class
{
    [Start]
    public void Function()
    {
        float fltResultFloat = 0;
        fltResultFloat = 10 / 3;
        MessageBox.Show("10 / 3 = " + fltResultFloat.ToString());

        return;
    }
}



