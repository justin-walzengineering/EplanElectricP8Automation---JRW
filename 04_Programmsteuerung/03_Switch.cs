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
            MessageBoxIcon.Question);

        switch (Result)
        {
            case DialogResult.Yes:
                MessageBox.Show("Es wurde 'Ja' gedrückt.");
                break;

            case DialogResult.No:
                goto default;

            default:
                MessageBox.Show("Es wurde 'Nein' oder"
                + "'Abbrechen' gedrückt.");
                break;
        }

        return;
    }
}



