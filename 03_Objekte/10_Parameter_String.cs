using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class Class
{
    [DeclareAction("StringParameter")]
    public void Function(string ParaString)
    {
        MessageBox.Show(ParaString);

        return;
    }
}



