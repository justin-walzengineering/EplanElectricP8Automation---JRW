using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class Class
{
    [DeclareAction("Actionname")]
    public void Function()
    {
        MessageBox.Show("Ich kann Scripten!");

        return;
    }
}



