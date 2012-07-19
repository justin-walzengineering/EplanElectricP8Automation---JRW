using System;
using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class Class
{
    [Start]
    public void Function()
    {
        MessageBox.Show("Ich bin ein Text (aber eigentlich ein String)!");

        string strMessage1 = string.Empty;
        strMessage1 = "Ich bin ein String mit\nZeilenumbruch!";
        MessageBox.Show(strMessage1);

        string strMessage2 = "Ich bin auch ein String!";
        MessageBox.Show(strMessage2);
        strMessage2 = "Mir kann man auch einen neuen Text übergeben!";
        MessageBox.Show(strMessage2);

        string strMessage3_1 = "Und ich ";
        string strMessage3_2 = "bin auch ";
        string strMessage3_3 = "einer!";
        MessageBox.Show(strMessage3_1 + strMessage3_2 + strMessage3_3);

        MessageBox.Show("Wenn man einen Zeilenumbruch im Code eingibt "
                        + "wird dieser nicht angezeigt!");

        string strMessage4 = "Der {0} ist im {1}.";
        string strMessage4_1 = String.Format(strMessage4, "Kamm", "Schrank");
        string strMessage4_2 = String.Format(strMessage4, "Schrank", "Badezimmer");
        MessageBox.Show(strMessage4_1);
        MessageBox.Show(strMessage4_2);

        return;
    }
}



