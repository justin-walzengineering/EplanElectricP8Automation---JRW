using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

// Goal:
// Builds .xls files for summarized parts list and labeling

// Run script in Eplan using [Utilities]>[Scripts]>[Run]
// Then choose the file from the file location. 
// The file will be a .cs extension.

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
                "Item summary list is created...");
            ActionCallingContext labellingContext =
                new ActionCallingContext();
            labellingContext.AddParameter("CONFIGSCHEME",
                "Summarized parts list");
            labellingContext.AddParameter("DESTINATIONFILE",
                strProjectpath + "Summarized_parts_list.xls");
            labellingContext.AddParameter("FILTERSCHEME", "");
            labellingContext.AddParameter("LANGUAGE", "en_US");
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
                "Device label is created...");
            ActionCallingContext labellingContext1 =
                new ActionCallingContext();
            labellingContext1.AddParameter("CONFIGSCHEME",
                "Device tag list");
            labellingContext1.AddParameter("DESTINATIONFILE",
                strProjectpath + "Labeling_equipment.xls");
            labellingContext1.AddParameter("FILTERSCHEME", "");
            labellingContext1.AddParameter("LANGUAGE", "en_US");
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



