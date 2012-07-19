using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class Class
{
    [Start]
    public void Function()
    {
        string strProjectpath =
            PathMap.SubstitutePath("$(PROJECTPATH)" + @"\");

        Progress progress = new Progress("SimpleProgress");
        progress.BeginPart(100, "");
        progress.SetAllowCancel(true);
        if (!progress.Canceled())
        {
            progress.BeginPart(50,
                "Artikelsummenstückliste wird erstellt...");
            ActionCallingContext labellingContext =
                new ActionCallingContext();
            labellingContext.AddParameter("CONFIGSCHEME",
                "Summarized parts list");
            labellingContext.AddParameter("DESTINATIONFILE",
                strProjectpath + "Artikelsummenstückliste.xls");
            labellingContext.AddParameter("FILTERSCHEME", "");
            labellingContext.AddParameter("LANGUAGE", "de_DE");
            labellingContext.AddParameter("LogMsgActionDone", "true");
            labellingContext.AddParameter("SHOWOUTPUT", "1");
            labellingContext.AddParameter("RECREPEAT", "1");
            labellingContext.AddParameter("SORTSCHEME", "");
            labellingContext.AddParameter("TASKREPEAT", "1");
            new CommandLineInterpreter().Execute("label",
                labellingContext);
            progress.EndPart();
        }
        if (!progress.Canceled())
        {
            progress.BeginPart(50,
                "Betriebsmittelbeschriftung wird erstellt...");
            ActionCallingContext labellingContext1 =
                new ActionCallingContext();
            labellingContext1.AddParameter("CONFIGSCHEME",
                "Device tag list");
            labellingContext1.AddParameter("DESTINATIONFILE",
                strProjectpath + "Betriebsmittelbeschriftung.xls");
            labellingContext1.AddParameter("FILTERSCHEME", "");
            labellingContext1.AddParameter("LANGUAGE", "de_DE");
            labellingContext1.AddParameter("LogMsgActionDone", "true");
            labellingContext1.AddParameter("SHOWOUTPUT", "1");
            labellingContext1.AddParameter("RECREPEAT", "1");
            labellingContext1.AddParameter("SORTSCHEME", "");
            labellingContext1.AddParameter("TASKREPEAT", "1");
            new CommandLineInterpreter().Execute("label",
                labellingContext1);
            progress.EndPart();
        }

        progress.EndPart(true);

        return;
    }
}



