using System;
using System.Diagnostics; // Additionally
using System.Windows.Forms;
using Eplan.EplApi.Scripting;

// Goal:
// Open the calculator by starting the calculator process

// Run script in Eplan using [Utilities]>[Scripts]>[Run]
// Then choose the file from the file location. 
// The file will be a .cs extension.

public class Class
{
    [Start]
    public void Function()
    {
        try
        {
            Process.Start("calc");
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
        }

        return;
    }
}

