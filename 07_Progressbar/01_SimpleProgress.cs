using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;
using System.Threading;

// Goal:
// Display a progress bar and show time elapsing. 
// Sleep time between each cycle is 1 second

// Run script in Eplan using [Utilities]>[Scripts]>[Run]
// Then choose the file from the file location. 
// The file will be a .cs extension.

public class Class
{
    [Start]
    public void Function()
    {
        Progress oProgress = new Progress("SimpleProgress");
        oProgress.SetAllowCancel(true);
        oProgress.SetAskOnCancel(true);
        oProgress.SetNeededSteps(3);
        oProgress.SetTitle("My progress bar");
        oProgress.ShowImmediately();

        if (!oProgress.Canceled())
        {
            oProgress.SetActionText("Step 1");
            oProgress.SetTitle("Headline 1");
            oProgress.Step(1);

            Thread.Sleep(1000);
        }

        if (!oProgress.Canceled())
        {
            oProgress.SetActionText("Step 2");
            oProgress.SetTitle("Headline 2");
            oProgress.Step(1);

            Thread.Sleep(1000);
        }

        if (!oProgress.Canceled())
        {
            oProgress.SetActionText("Step 3");
            oProgress.SetTitle("Headline 3");
            oProgress.Step(1);

            Thread.Sleep(1000);
        }

        oProgress.EndPart(true);

        return;
    }
}



