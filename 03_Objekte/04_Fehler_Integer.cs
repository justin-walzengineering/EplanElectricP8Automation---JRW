using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class Class
{
    [Start]
    public void Function()
    {
        string strNumber1 = "10";
        string strNumber2 = "2";
        string strResultString = strNumber1 + strNumber2;

        MessageBox.Show(strResultString);

        int intResult = 0;
        int intNumber1 = 10;
        int intNumber2 = 0;

        intResult = intNumber1 / intNumber2;
        MessageBox.Show(intResult.ToString());

        return;
    }
}



