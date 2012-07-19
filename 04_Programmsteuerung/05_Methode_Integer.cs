using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class Class
{
    [DeclareAction("MethodeInt")]
    public void Function(int INT1, int INT2)
    {
        CalcMessageBox(INT1, INT2);
        FinishedMessageBox2();

        return;
    }

    private static void CalcMessageBox(int INT1, int INT2)
    {
        int intResult = INT1 + INT2;
        MessageBox.Show(INT1.ToString() +
            " + " + INT2.ToString() +
            " = " + intResult.ToString());

        return;
    }

    private static void FinishedMessageBox2()
    {
        MessageBox.Show("Berechnung abgeschlossen.");

        return;
    }
}



