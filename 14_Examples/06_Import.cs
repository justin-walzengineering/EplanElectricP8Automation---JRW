using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

// Goal:
// Imports a .dxf file
// Have to be sure the file location for the .dxf file being called is correct

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

        acc.AddParameter("TYPE", "DXFPAGE");
        acc.AddParameter("IMPORTFILE", @"C:\DXF\Smile.dxf");

        oCLI.Execute("import", acc);

        return;
    }
}
