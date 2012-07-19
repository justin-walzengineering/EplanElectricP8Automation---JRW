using System;
using System.Diagnostics; // Zusätzlich
using System.Windows.Forms;
using Eplan.EplApi.Scripting;

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
                "Fehler",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
        }

        return;
    }
}

