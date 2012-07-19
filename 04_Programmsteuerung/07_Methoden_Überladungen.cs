using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class Class
{
    [Start]
    public void Function()
    {
        string strMessage = string.Empty;

        strMessage = DoSomething("Bananen");

        MessageBox.Show(strMessage,
            "Information",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

        strMessage = DoSomething("Bananen", "3");

        MessageBox.Show(strMessage,
            "Information",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

        return;
    }

    /// <summary>
    /// Gibt einen Wert zurück der den Satz enthält:
    /// "Ich habe gerade [Food] gegessen!"
    /// </summary>
    /// <param name="Food">Nahrungsmittel</param>
    private static string DoSomething(string Food)
    {
        string strFullMessage = "Ich habe gerade "
            + Food + " gegessen!";

        return strFullMessage;
    }

    /// <summary>
    /// Gibt einen Wert zurück der den Satz enthält:
    /// "Ich habe gerade [Amount] [Food] gegessen!"
    /// </summary>
    /// <param name="Food">Nahrungsmittel</param>
    /// <param name="Amount">Menge</param>
    private static string DoSomething(string Food, string Amount)
    {
        string strFullMessage = "Ich habe gerade "
            + Amount + " " + Food + " gegessen!";

        return strFullMessage;
    }

}



