using System.Windows.Forms;
using Eplan.EplApi.Scripting;

// Goal:
// Display message box and react using switch and case statements depending on user response

// Run script in Eplan using [Utilities]>[Scripts]>[Run]
// Then choose the file from the file location. 
// The file will be a .cs extension.

public class Class
{
    [Start]
    public void Function()
    {
        DialogResult Result = MessageBox.Show("Should the action be executed?", "Headline", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

        switch (Result)
        {
            case DialogResult.Yes:
                MessageBox.Show("It was pressed 'Yes'.");
                break;

            case DialogResult.No:
                goto default;

            default:
                MessageBox.Show("It became 'No' or " + "'Cancel' pressed.");
                break;
        }

        return;
    }
}



