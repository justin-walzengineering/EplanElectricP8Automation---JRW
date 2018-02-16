using System.IO;
using System.Text;
using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

// Goal:
// Couldn't get this to run correctly.
// My guess is it's supposed to open a text file and return information from the file. 

// Run script in Eplan using [Utilities]>[Scripts]>[Run]
// Then choose the file from the file location. 
// The file will be a .cs extension.

public class Class
{
    [Start]
    public void Function()
    {
        string filename =
            PathMap.SubstitutePath(@"$(TMP)\Last_Version.txt");

        LabellingText(filename);

        string LastVersion = ReadLine(filename, 1);

        MessageBox.Show(
            "Last used EPLAN-Version:\n"
            + LastVersion,
            "Information",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
            );

        File.Delete(filename);

        return;
    }

    public string ReadLine(string strFilename, int intLine)
    {
        string strContent = "";
        float fRow = 0;

        StreamReader srTextfile = new StreamReader(
            strFilename, Encoding.Unicode);

        while (!srTextfile.EndOfStream && fRow < intLine)
        {
            fRow += 1;
            strContent = srTextfile.ReadLine();
        }

        if (fRow < intLine)
        {
            strContent = "";
        }

        srTextfile.Close();

        return strContent;
    }

    private static void LabellingText(string filename)
    {
        ActionCallingContext acc = new ActionCallingContext();
        acc.AddParameter("CONFIGSCHEME",
            "Last used EPLAN-Version_Textdatei");
        acc.AddParameter("DESTINATIONFILE", filename);
        acc.AddParameter("FILTERSCHEME", "");
        acc.AddParameter("LANGUAGE", "en_US");
        acc.AddParameter("LogMsgActionDone", "true");
        acc.AddParameter("SHOWOUTPUT", "0");
        acc.AddParameter("RECREPEAT", "1");
        acc.AddParameter("SORTSCHEME", "");
        acc.AddParameter("TASKREPEAT", "1");
        new CommandLineInterpreter().Execute("label", acc);

        return;
    }

}



