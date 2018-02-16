using System;
using System.Windows.Forms;
using Eplan.EplApi.Scripting;

// Goal:
// Display different message boxes with formatting to show examples of 
// text styles

// Run script in Eplan using [Utilities]>[Scripts]>[Run]
// Then choose the file from the file location. 
// The file will be a .cs extension.

public class Class
{
    [Start]
    public void Function()
    {
        MessageBox.Show("I am a text (but actually a string)");

        string strMessage1 = string.Empty;
        strMessage1 = "I am a string with\nWord wrap!";
        MessageBox.Show(strMessage1);

        string strMessage2 = "I am also a string!";
        MessageBox.Show(strMessage2);
        strMessage2 = "You can also give me a new text!";
        MessageBox.Show(strMessage2);

        string strMessage3_1 = "And me ";
        string strMessage3_2 = "I am too ";
        string strMessage3_3 = "Also!";
        MessageBox.Show(strMessage3_1 + strMessage3_2 + strMessage3_3);

        MessageBox.Show("If you enter a line break in the code "
                        + "will not be displayed!");

        string strMessage4 = "The {0} is in {1}.";
		
		// This format will place Comb into {0} location and cupboard into {1}
        string strMessage4_1 = String.Format(strMessage4, "Comb", "cupboard");
        string strMessage4_2 = String.Format(strMessage4, "Closet", "bathroom");
        MessageBox.Show(strMessage4_1);
        MessageBox.Show(strMessage4_2);

        return;
    }
}



