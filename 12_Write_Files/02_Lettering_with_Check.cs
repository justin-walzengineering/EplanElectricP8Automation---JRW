using System.IO;
using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

// Goal:
// Builds .xls files for summarized parts list and labeling

// Run script in Eplan using [Utilities]>[Scripts]>[Run]
// Then choose the file from the file location. 
// The file will be a .cs extension.

public class Class
{
    [Start]
    public void Function()
    {
        string strFilename = string.Empty;

        strFilename = CheckFilename("Summarized_parts_list.xls");
        if (strFilename != "")
        {
            ActionCallingContext labellingContext =
                new ActionCallingContext();
            labellingContext.AddParameter("CONFIGSCHEME",
                "Summarized parts list");
            labellingContext.AddParameter("DESTINATIONFILE",
                strFilename);
            labellingContext.AddParameter("FILTERSCHEME", "");
            labellingContext.AddParameter("LANGUAGE", "en_US");
            labellingContext.AddParameter("LogMsgActionDone", "true");
            labellingContext.AddParameter("SHOWOUTPUT", "1");
            labellingContext.AddParameter("RECREPEAT", "1");
            labellingContext.AddParameter("SORTSCHEME", "");
            labellingContext.AddParameter("TASKREPEAT", "1");
            new CommandLineInterpreter().Execute("label",
                labellingContext);
        }

        strFilename = CheckFilename("Labeling_equipment.xls");
        if (strFilename != "")
        {
            ActionCallingContext labellingContext1 =
                new ActionCallingContext();
            labellingContext1.AddParameter("CONFIGSCHEME",
                "Device tag list");
            labellingContext1.AddParameter("DESTINATIONFILE",
                strFilename);
            labellingContext1.AddParameter("FILTERSCHEME", "");
            labellingContext1.AddParameter("LANGUAGE", "de_DE");
            labellingContext1.AddParameter("LogMsgActionDone", "true");
            labellingContext1.AddParameter("SHOWOUTPUT", "1");
            labellingContext1.AddParameter("RECREPEAT", "1");
            labellingContext1.AddParameter("SORTSCHEME", "");
            labellingContext1.AddParameter("TASKREPEAT", "1");
            new CommandLineInterpreter().Execute("label",
                labellingContext1);
        }

        return;
    }

    private static string CheckFilename(string strType)
    {
        string strProjectpath =
            PathMap.SubstitutePath("$(PROJECTPATH)" + @"\");

        string strFilename = strProjectpath + strType;

        if (File.Exists(strFilename))
        {
            DialogResult Result = MessageBox.Show(
                "The file\n'"
                + strFilename +
                "'\nalready exists.\n"
                + "Do you want to overwrite the file?",
                "labeling",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (Result == DialogResult.No)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.DefaultExt = "xls";
                sfd.FileName = strType;
                sfd.Filter = "Excel-File (*.xls)|*.xls";
                sfd.InitialDirectory = strProjectpath;
                sfd.Title = "Location for " + strType + " choose:";
                sfd.ValidateNames = true;

                DialogResult ResultSfd = sfd.ShowDialog();
                if (ResultSfd == DialogResult.OK)
                {
                    strFilename = sfd.FileName;
                }
                else if (ResultSfd == DialogResult.Cancel)
                {
                    strFilename = "";
                }
            }

        }
        return strFilename;
    }
}



