using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

// Goal:
// Will show system messages and give an overview of errors, fatal errors, messages, warnings, etc. 

// Run script in Eplan using [Utilities]>[Scripts]>[Run]
// Then choose the file from the file location. 
// The file will be a .cs extension.

public class Class
{
    [Start]
    public void Function()
    {
        Eplan.EplApi.Base.BaseException bexAssert = new BaseException("Assert", MessageLevel.Assert);
        bexAssert.FixMessage();

        Eplan.EplApi.Base.BaseException bexError = new BaseException("Error", MessageLevel.Error);
        bexError.FixMessage();

        Eplan.EplApi.Base.BaseException bexFatalError = new BaseException("FatalError", MessageLevel.FatalError);
        bexFatalError.FixMessage();

        Eplan.EplApi.Base.BaseException bexMessage = new BaseException("Message", MessageLevel.Message);
        bexMessage.FixMessage();

        Eplan.EplApi.Base.BaseException bexTrace = new BaseException("Trace", MessageLevel.Trace);
        bexTrace.FixMessage();

        Eplan.EplApi.Base.BaseException bexWarning = new BaseException("Warning", MessageLevel.Warning);
        bexWarning.FixMessage();

        CommandLineInterpreter oCLI = new CommandLineInterpreter();
        oCLI.Execute("SystemErrDialog");
           
        return;
    }
}



