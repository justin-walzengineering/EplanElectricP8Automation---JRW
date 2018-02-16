using System.Windows.Forms;
using System.Xml;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

// Goal:
// Not sure what this one is doing completely. 
// Looks like it is opening the specific project .xml file and read/display information about file.

// Run script in Eplan using [Utilities]>[Scripts]>[Run]
// Then choose the file from the file location. 
// The file will be a .cs extension.

public class Class
{
    [Start]
    public void Function()
    {
        string filename =
            PathMap.SubstitutePath("$(PROJECTPATH)" + @"\"
            + "Projectinfo.xml");

        string LastVersion = ReadXml(filename, 10043);

        MessageBox.Show(
            "Last used EPLAN-Version:\n"
            + LastVersion,
            "Information",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
            );

        return;
    }

    private static string ReadXml(string filename, int ID)
    {
        string strLastVersion = "";

        XmlTextReader reader = new XmlTextReader(filename);

        while (reader.Read())
        {
            if (reader.HasAttributes)
            {
                while (reader.MoveToNextAttribute())
                {
                    if (reader.Name == "id")
                    {
                        if (reader.Value == ID.ToString())
                        {
                            strLastVersion = reader.ReadString();
                            reader.Close();
                            return strLastVersion;
                        }
                    }
                }
            }
        }

        return strLastVersion;
    }

}



