using System.Windows.Forms;
using Eplan.EplApi.Scripting;
using System;

// Goal:
// Attempt to do a calculation that will throw a fault (in this case dividing by zero)
// The Try command will attempt to run the calculation, when the error flag is thrown, the catch command is ran. 

// Run script in Eplan using [Utilities]>[Scripts]>[Run]
// Then choose the file from the file location. 
// The file will be a .cs extension.

public class Class
{
    [Start]
    public void Function()
    {
        int intResult = 0;
        int intNumber1 = 10;
        int intNumber2 = 0;

        try
        {
            intResult = intNumber1 / intNumber2;

            // From here no code is executed
            MessageBox.Show(intResult.ToString());
            MessageBox.Show("Calculation completed successfully");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        
         // From here the code is executed again
        MessageBox.Show("Calculation finished");

        return;
    }
}



