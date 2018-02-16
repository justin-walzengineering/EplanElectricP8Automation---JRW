using System.Diagnostics;
using System.Windows.Forms;
using System.Xml;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

// Goal:
// Creates a xml file and opens that file up

// Run script in Eplan using [Utilities]>[Scripts]>[Run]
// Then choose the file from the file location. 
// The file will be a .cs extension.

public class Class
{
    [Start]
    public void Function()
    {
        string filename =
            PathMap.SubstitutePath(@"$(PROJECTPATH)\Test_dates.xml");

        XmlWriterSettings xs = new XmlWriterSettings();
        xs.Indent = true;
        xs.IndentChars = "\t";

        XmlWriter xw = XmlWriter.Create(filename, xs);

        xw.WriteStartDocument();

        // People: Start
        xw.WriteStartElement("People");

            // Person 1
            xw.WriteStartElement("Person");
                xw.WriteElementString("FirstName", "John");
                xw.WriteElementString("LastName", "Doe");
                xw.WriteStartElement("Address");
                xw.WriteAttributeString("City", "Chicago");
                xw.WriteAttributeString("State", "Illinois");
                xw.WriteEndElement();
            xw.WriteEndElement();

            // Person 2
        xw.WriteStartElement("Person");
            xw.WriteElementString("FirstName", "Jane");
            xw.WriteElementString("LastName", "Doe");
            xw.WriteStartElement("Address");
            xw.WriteAttributeString("City", "Chicago");
            xw.WriteAttributeString("State", "Illinois");
            xw.WriteEndElement();
        xw.WriteEndElement();

        // People: The end
        xw.WriteEndElement();

        xw.WriteEndDocument();
        xw.Close();

        MessageBox.Show(
            "XML-File successfully exported.",
            "Information",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
            );

        Process.Start(filename);

        return;
    }

}



