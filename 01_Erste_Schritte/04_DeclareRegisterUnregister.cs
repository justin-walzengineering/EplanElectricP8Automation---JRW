using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class Class
{
    [DeclareRegister]
    public void Register()
    {
        MessageBox.Show("Script geladen.");

        return;
    }

    [DeclareUnregister]
    public void UnRegister()
    {
        MessageBox.Show("Script entladen.");

        return;
    }
}



