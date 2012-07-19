using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;
using System.Threading;

public class Class
{
    [Start]
    public void Function()
    {
        Progress oProgress = new Progress("SimpleProgress");
        oProgress.SetAllowCancel(true);
        oProgress.SetAskOnCancel(true);
        oProgress.SetNeededSteps(3);
        oProgress.SetTitle("Meine Progressbar");
        oProgress.ShowImmediately();

        if (!oProgress.Canceled())
        {
            oProgress.SetActionText("Step 1");
            oProgress.SetTitle("Titelzeile 1");
            oProgress.Step(1);

            Thread.Sleep(1000);
        }

        if (!oProgress.Canceled())
        {
            oProgress.SetActionText("Step 2");
            oProgress.SetTitle("Titelzeile 2");
            oProgress.Step(1);

            Thread.Sleep(1000);
        }

        if (!oProgress.Canceled())
        {
            oProgress.SetActionText("Step 3");
            oProgress.SetTitle("Titelzeile 3");
            oProgress.Step(1);

            Thread.Sleep(1000);
        }

        oProgress.EndPart(true);

        return;
    }
}



