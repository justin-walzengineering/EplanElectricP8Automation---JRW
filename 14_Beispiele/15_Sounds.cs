using System;
using System.Media;
using System.Windows.Forms;
using Eplan.EplApi.Scripting;

class Class
{
    [Start]
    public void Function()
    {
        MessageBox.Show(
            "Systemsound wird ausgegeben...",
            "Hinweis",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
            );

        SystemSounds.Beep.Play();

        MessageBox.Show(
            "Hardwaresound wird ausgegeben...",
            "Hinweis",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
            );

        Console.Beep();

        MessageBox.Show(
            "Hardwaresound wird mit Frequenz ausgegeben...\n"
                + "1000 Millisekunden\n"
                + "1000 Hz",
            "Hinweis",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
            );

        Console.Beep(1000,1000);

        return;
    }

}