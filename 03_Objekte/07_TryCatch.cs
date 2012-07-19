using System.Windows.Forms;
using Eplan.EplApi.Scripting;
using System;

public class Class
{
    [Start]
    public void Function()
    {
        int intResult = 0;
        int intNumber1 = 10;
        int intNumber2 = 0;

        try
        {
            intResult = intNumber1 / intNumber2;

            //Ab hier wird kein Code mehr ausgeführt
            MessageBox.Show(intResult.ToString());
            MessageBox.Show("Berechnung erfolgreich beendet");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        
         //Ab hier wird der Code wieder ausgeführt
        MessageBox.Show("Berechnung beendet");

        return;
    }
}



