using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class Class
{
    [Start]
    public void Function()
    {
        DialogResult Result = MessageBox.Show(
            "Soll die Aktion ausgeführt werden?",
            "Titelzeile",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question
            );

        if (Result == DialogResult.Yes)
        {
            MessageBox.Show("Es wurde 'Ja' gedrückt.");
        }
        else if (Result == DialogResult.No)
        {
            MessageBox.Show("Es wurde 'Nein' gedrückt.");
        }
        else if (Result == DialogResult.Cancel)
        {
            MessageBox.Show("Es wurde 'Abbrechen' gedrückt.");
        }

        return;
    }
}



