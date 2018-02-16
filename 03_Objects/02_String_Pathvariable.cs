using System.Windows.Forms;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

// Goal:
// Display project information, in this case the project name, in message box

// Run script in Eplan using [Utilities]>[Scripts]>[Run]
// Then choose the file from the file location. 
// The file will be a .cs extension.

public class Class
{
    [Start]
    public void Function()
    {
        string strProjectname = PathMap.SubstitutePath("$(PROJECTNAME)");
        
        MessageBox.Show(strProjectname);

        return;
    }
}



