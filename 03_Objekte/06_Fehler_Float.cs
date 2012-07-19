using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class Class
{
    [Start]
    public void Function()
    {
        float fltResultFloat = 0;
        fltResultFloat = 10 / 3;
        MessageBox.Show("10 / 3 = " + fltResultFloat.ToString());

        return;
    }
}



