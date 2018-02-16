using System;
using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

// Goal:
// Create a new action that will be used to ask for a two integers, in which it will use these to calculate and display certain values in a message box

// Load script in Eplan using [Utilities]>[Scripts]>[Load]
// Then choose the file from the file location. 
// The file will be a .cs extension.

public class Class
{
    [DeclareAction("Connectionbranches")]
    public void Function(int SET)
    {
        try
        {
            string strScripts =
                PathMap.SubstitutePath("$(MD_SCRIPTS)" + @"\");
            string strProject = PathMap.SubstitutePath("$(P)");
            string strMessage = string.Empty;

            CommandLineInterpreter oCLI = new CommandLineInterpreter();
            ActionCallingContext acc = new ActionCallingContext();
            acc.AddParameter("Project", strProject);

            switch (SET)
            {
                case 1:
                    strMessage = "[As drawn]";
                    acc.AddParameter("XMLFile", strScripts + @"1.xml");
                    break;

                case 2:
                    strMessage = "[As a point]";
                    acc.AddParameter("XMLFile", strScripts + @"2.xml");
                    break;

                case 3:
                    strMessage = "[With goal setting]";
                    acc.AddParameter("XMLFile", strScripts + @"3.xml");
                    break;

                default:
                    MessageBox.Show("Parameter not known", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            oCLI.Execute("XSettingsImport", acc);

            MessageBox.Show("Settings have been imported.\n" + strMessage, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return;
    }

}