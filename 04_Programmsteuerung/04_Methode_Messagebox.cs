using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class Class
{
    [DeclareAction("MethodeMessagebox")]
    public void Function(int INT1, int INT2)
    {
        int intResult = INT1 + INT2;

        MessageBox.Show(INT1.ToString() +
            " + " + INT2.ToString() +
            " = " + intResult.ToString());

        FinishedMessageBox1();

        return;
    }

    private static void FinishedMessageBox1()
    {
        MessageBox.Show("Berechnung abgeschlossen.");

        return;
    }
}



