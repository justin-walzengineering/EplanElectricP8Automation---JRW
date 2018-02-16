using System.Windows.Forms;
using Eplan.EplApi.Scripting;

// Goal:
// Display message box and react using if statements depending on user response

// Run script in Eplan using [Utilities]>[Scripts]>[Run]
// Then choose the file from the file location. 
// The file will be a .cs extension.

public class Class
{
    [Start]
    public void Function()
    {
        DialogResult Result = MessageBox.Show("Should the action be executed?", "Headline", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

        if (Result == DialogResult.Yes)
        {
            MessageBox.Show("It was pressed 'Yes'.");
        }
        else if (Result == DialogResult.No)
        {
            MessageBox.Show("It was pressed 'No'.");
        }
        else if (Result == DialogResult.Cancel)
        {
            MessageBox.Show("It was pressed 'Cancel'.");
        }

        return;
    }
}



