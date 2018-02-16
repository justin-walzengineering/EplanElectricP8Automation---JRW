using System.Windows.Forms;
using Eplan.EplApi.Scripting;

// Goal:
// Create a new action that will be used to ask for a string and then display that string in a message box

// Load script in Eplan using [Utilities]>[Scripts]>[Load]
// Then choose the file from the file location. 
// The file will be a .cs extension.

public class Class
{
    [DeclareAction("StringParameter")]
    public void Function(string ParaString)
    {
        MessageBox.Show(ParaString);

        return;
    }
}



