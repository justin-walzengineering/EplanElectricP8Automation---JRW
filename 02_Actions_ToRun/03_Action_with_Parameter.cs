using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

// Goal:
// Execute an action in a project using a user input
// When ran, if you select a text property, the font size will be formatted to 20
// This can be ran by selecting the text and then running script
// or running script and then selecting text

// Run script in Eplan using [Utilities]>[Scripts]>[Run]
// Then choose the file from the file location. 
// The file will be a .cs extension.

public class Class
{
    [Start]
    public void Function()
    {
        CommandLineInterpreter oCLI = new CommandLineInterpreter();
        ActionCallingContext acc = new ActionCallingContext();

        acc.AddParameter("Name", "XGedIaFormatText");
        acc.AddParameter("height", "1");

        oCLI.Execute("XGedStartInteractionAction", acc);

        return;
    }
}



