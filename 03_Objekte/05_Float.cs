using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class Class
{
    [Start]
    public void Function()
    {
        float fltResultFloat = 0;
        float fltNumber1 = 10;
        float fltNumber2 = 3;

        fltResultFloat = fltNumber1 / fltNumber2;
        MessageBox.Show(fltResultFloat.ToString());

        return;
    }
}



