using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class Class
{
    [DeclareAction("IfString")]
    public void Function(string ParaString)
    {
        if (ParaString == "JA")
        {
            MessageBox.Show("Bedingung erfüllt.");
        }
        else
        {
            MessageBox.Show("Bedingung nicht erfüllt.");
        }

        if (ParaString.ToUpper() == "JA")
        {
            MessageBox.Show("Bedingung erfüllt.");
        }
        else
        {
            MessageBox.Show("Bedingung nicht erfüllt.");
        }

        return;
    }
}
