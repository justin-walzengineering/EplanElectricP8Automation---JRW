using System.Windows.Forms;
using Eplan.EplApi.Scripting;

// Goal:
// Create a new action that will be used to ask for a string, in which it will be used to display values dependent on conditions of the if statements

// Load script in Eplan using [Utilities]>[Scripts]>[Load]
// Then choose the file from the file location. 
// The file will be a .cs extension.

public class Class
{
    [DeclareAction("IfString")]
    public void Function(string ParaString)
    {
        if (ParaString == "AND")
        {
            MessageBox.Show("Conditions met.");
        }
        else
        {
            MessageBox.Show("Condition not fulfilled.");
        }

        if (ParaString.ToUpper() == "AND")
        {
            MessageBox.Show("conditions met.");
        }
        else
        {
            MessageBox.Show("Condition not fulfilled.");
        }

        return;
    }
}
