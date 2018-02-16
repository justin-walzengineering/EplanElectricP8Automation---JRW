using System.Windows.Forms;
using Eplan.EplApi.Scripting;

// Goal:
// Display integers in message box that includes decimal point, using floating numbers

// Run script in Eplan using [Utilities]>[Scripts]>[Run]
// Then choose the file from the file location. 
// The file will be a .cs extension.

public class Class
{
    [Start]
    public void Function()
    {
        float fltResultFloat = 0;
        float fltNumber1 = 10;
        float fltNumber2 = 3;

        fltResultFloat = fltNumber1 / fltNumber2;
        MessageBox.Show(fltResultFloat.ToString());

        return;
    }
}



