using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

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
