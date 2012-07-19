using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class Class
{
    [DeclareEventHandler("onActionStart.String.XPrjActionProjectClose")]
    public void Function()
    {
        MessageBox.Show("Ich kann Scripten!");

        return;
    }
}



