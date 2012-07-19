using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class Class
{
    [DeclareAction("IntParameter")]
    public void Function(int INT1, int INT2)
    {
        int ResultInt = INT1 + INT2;
        MessageBox.Show(INT1.ToString() +
            " + " + INT2.ToString() +
            " = " + ResultInt.ToString());

        return;
    }
}



