using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

// Goal:
// Execute multiple actions in a project
// 1: This is used to check a project that it is correct
// 2: Update reports for project
// 3: Run Actionname (from Folder 01 - Declare Action)

// Run script in Eplan using [Utilities]>[Scripts]>[Run]
// Then choose the file from the file location. 
// The file will be a .cs extension.

public class Class
{
    [Start]
    public void Function()
    {
        CommandLineInterpreter oCLI = new CommandLineInterpreter();

        oCLI.Execute("XMsgActionStartVerification");
        oCLI.Execute("reports");
        oCLI.Execute("Actionname");

        return;
    }
}



