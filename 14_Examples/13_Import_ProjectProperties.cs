using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

// Goal:
// Imports properties from one project to another
// Asks user to select other project that has properties to import

// Run script in Eplan using [Utilities]>[Scripts]>[Run]
// Then choose the file from the file location. 
// The file will be a .cs extension.

public class Class
{
    [Start]
    public void Function()
    {
        string strProjects =
            PathMap.SubstitutePath("$(MD_PROJECTS)");
        string strFilename = string.Empty;

        OpenFileDialog ofd = new OpenFileDialog();
        ofd.Filter = "ProjectInfo.xml|ProjectInfo.xml";
        ofd.InitialDirectory = strProjects;
        ofd.Title = "Select project properties:";
        ofd.ValidateNames = true;

        if (ofd.ShowDialog() == DialogResult.OK)
        {
            strFilename = ofd.FileName;

            Progress oProgress = new Progress("SimpleProgress");
            oProgress.SetAllowCancel(false);
            oProgress.BeginPart(100, "");
            oProgress.SetTitle("Import project properties");
            oProgress.ShowImmediately();

            CommandLineInterpreter oCLI = new CommandLineInterpreter();
            ActionCallingContext cc = new ActionCallingContext();

            cc.AddParameter("TYPE", "READPROJECTINFO");
            cc.AddParameter("FILENAME", strFilename);
            oCLI.Execute("projectmanagement", cc);

            oProgress.EndPart(true);

            oCLI.Execute("XPrjActionPropertiesEdit");
        }

        return;
    }
}

