using System;
using System.Media;
using System.Windows.Forms;
using Eplan.EplApi.Scripting;

// Goal:
// Displays message box and plays sound.

// Run script in Eplan using [Utilities]>[Scripts]>[Run]
// Then choose the file from the file location. 
// The file will be a .cs extension.

class Class
{
    [Start]
    public void Function()
    {
        MessageBox.Show(
            "System sound is output...",
            "Note",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
            );

        SystemSounds.Beep.Play();

        MessageBox.Show(
            "Hardware sound is output...",
            "Note",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
            );

        Console.Beep();

        MessageBox.Show(
            "Hardware sound is output with frequency...\n"
                + "1000 milliseconds\n"
                + "1000 Hz",
            "Note",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
            );

        Console.Beep(1000,1000);

        return;
    }

}