using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

// Goal:
// Creates a pdf after closing a project. 
// Works off an event, which is closing the project

// Load script in Eplan using [Utilities]>[Scripts]>[Load]
// Then choose the file from the file location. 
// The file will be a .cs extension.

public class Class
{
    [DeclareEventHandler("Eplan.EplApi.OnUserPreCloseProject")]
    public void Function()
    {
        string strFullProjectname =
        PathMap.SubstitutePath("$(P)");
        string strProjectpath =
            PathMap.SubstitutePath("$(PROJECTPATH)" + @"\");
        string strProjectname =
            PathMap.SubstitutePath("$(PROJECTNAME)");

        DialogResult Result = MessageBox.Show(
            "Should a PDF for the project\n'"
            + strProjectname +
            "'\nbe generated?",
            "PDF-Export",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

        if (Result == DialogResult.Yes)
        {
            Progress oProgress = new Progress("SimpleProgress");
            oProgress.SetAllowCancel(true);
            oProgress.SetAskOnCancel(true);
            oProgress.BeginPart(100, "");
            oProgress.ShowImmediately();

            CommandLineInterpreter oCLI = new CommandLineInterpreter();
            ActionCallingContext acc = new ActionCallingContext();

            acc.AddParameter("TYPE", "PDFPROJECTSCHEME");
            acc.AddParameter("PROJECTNAME", strFullProjectname);
            acc.AddParameter("EXPORTFILE",
                strProjectpath + strProjectname);
            acc.AddParameter("EXPORTSCHEME", "EPLAN_default_value");

            oCLI.Execute("export", acc);

            oProgress.EndPart(true);
        }

        return;
    }
}



