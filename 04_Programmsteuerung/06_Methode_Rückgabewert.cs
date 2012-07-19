using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class Class
{
    [DeclareAction("MethodeIntRückgabewert")]
    public void Function(int INT1, int INT2)
    {
        //int intResult = Calc(INT1, INT2);

        int intResult = INT1 + INT2;

        MessageBox.Show(
            INT1.ToString() +
            " + " + INT2.ToString() +
            " = " + intResult.ToString()
            );

        FinishedMessageBox3();

        return;
    }

    private static int Calc(int INT1, int INT2)
    {
        return INT1 + INT2;
    }

    private static void FinishedMessageBox3()
    {
        MessageBox.Show("Berechnung abgeschlossen.");

        return;
    }

}



