using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

// Goal:
// Creates a text file and opens that file up

// Run script in Eplan using [Utilities]>[Scripts]>[Run]
// Then choose the file from the file location. 
// The file will be a .cs extension.

public class Class
{
    [Start]
    public void Function()
    {
        string filename =
            PathMap.SubstitutePath(@"$(PROJECTPATH)\Test_dates.txt");

        string strContent = "Example text\n";

        StreamWriter swTextfile = new StreamWriter(
            filename,
            true,
            Encoding.Unicode
            );

        swTextfile.Write(strContent);
        swTextfile.Close();

        MessageBox.Show(
            "Text file successfully exported.",
            "Information",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
            );

        Process.Start(filename);

        return;
    }

}



