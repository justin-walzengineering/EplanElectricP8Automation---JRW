using System.Diagnostics;
using System.Windows.Forms;
using System.Xml;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class Class
{
    [Start]
    public void Function()
    {
        string filename =
            PathMap.SubstitutePath(@"$(PROJECTPATH)\Testdatei.xml");

        XmlWriterSettings xs = new XmlWriterSettings();
        xs.Indent = true;
        xs.IndentChars = "\t";

        XmlWriter xw = XmlWriter.Create(filename, xs);

        xw.WriteStartDocument();

        // Personen: Start
        xw.WriteStartElement("Personen");

            // Person 1
            xw.WriteStartElement("Person");
                xw.WriteElementString("Vorname", "Max");
                xw.WriteElementString("Nachname", "Mustermann");
                xw.WriteStartElement("Adresse");
                xw.WriteAttributeString("Ort", "München");
                xw.WriteAttributeString("Straße", "Musterstraße 1");
                xw.WriteEndElement();
            xw.WriteEndElement();

            // Person 2
        xw.WriteStartElement("Person");
            xw.WriteElementString("Vorname", "Maria");
            xw.WriteElementString("Nachname", "Musterfrau");
            xw.WriteStartElement("Adresse");
            xw.WriteAttributeString("Ort", "München");
            xw.WriteAttributeString("Straße", "Musterstraße 2");
            xw.WriteEndElement();
        xw.WriteEndElement();

        // Personen: Ende
        xw.WriteEndElement();

        xw.WriteEndDocument();
        xw.Close();

        MessageBox.Show(
            "XML-Datei erfolgreich exportiert.",
            "Information",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
            );

        Process.Start(filename);

        return;
    }

}



