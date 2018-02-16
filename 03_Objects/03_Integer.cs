using System.Windows.Forms;
using Eplan.EplApi.Scripting;

// Goal:
// Display integers in message box continuously, while doing functions to the integers

// Run script in Eplan using [Utilities]>[Scripts]>[Run]
// Then choose the file from the file location. 
// The file will be a .cs extension.

public class Class
{
    [Start]
    public void Function()
    {
        int intResult = 0;
        int intNumber1 = 6;
        int intNumber2 = 3;

        MessageBox.Show(intNumber1.ToString());

        intResult = intNumber1 + intNumber2;
        MessageBox.Show(intResult.ToString());

        intResult = intNumber1 - intNumber2;
        MessageBox.Show(intResult.ToString());

        intResult = intNumber1 * intNumber2;
        MessageBox.Show(intResult.ToString());

        intResult = intNumber1 / intNumber2;
        MessageBox.Show(intResult.ToString());

        return;
    }
}



