using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class Class

// Goal:
// Diplay string values in a message box by running the public function and called private functions, passing along information between both

// Run script in Eplan using [Utilities]>[Scripts]>[Run]
// Then choose the file from the file location. 
// The file will be a .cs extension.

{
    [Start]
    public void Function()
    {
        string strMessage = string.Empty;

        strMessage = DoSomething("bananas");

        MessageBox.Show(strMessage, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        strMessage = DoSomething("bananas", "3");

        MessageBox.Show(strMessage, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        return;
    }

    // <summary>
	// Returns a value containing the sentence:
    // "I just ate [Food]!"
    // </summary>
    // <param name="Food">Food</param>
	
    private static string DoSomething(string Food)
    {
        string strFullMessage = "I have just eaten " + Food + "!";

        return strFullMessage;
    }

	// <summary>
    // Returns a value containing the sentence:
    // "I just ate [Amount] [Food]!"
    // </ summary>
    // <param name = "Food"> Food </ param>
    // <param name = "Amount"> Quantity </ param>
	
    private static string DoSomething(string Food, string Amount)
    {
        string strFullMessage = "I have just eaten " + Amount + " " + Food + "!";

        return strFullMessage;
    }

}



