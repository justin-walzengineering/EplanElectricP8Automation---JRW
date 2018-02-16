using System.Windows.Forms;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

// Goal:
// Display different texts in a message box. 
// The message box title can be modified (in this instance it is the project name)

// Run script in Eplan using [Utilities]>[Scripts]>[Run]
// Then choose the file from the file location. 
// The file will be a .cs extension.

public class Class
{
    [Start]
    public void Function()
    {
        string strProjectname = PathMap.SubstitutePath("$(PROJECTNAME)");
		
// This message box shows text in box and project names as title
        MessageBox.Show("Text", strProjectname);
		
// This message box shows buttons on bottom that are yes and no
        MessageBox.Show("Text", strProjectname, MessageBoxButtons.YesNo);
		
// This message box shows buttons on bottom that are abort, retry and ignore
        MessageBox.Show("Text", strProjectname, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);

        return;
    }
}