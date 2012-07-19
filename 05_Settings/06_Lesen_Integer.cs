using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class Class
{
    [Start]
    public void Function()
    {
        Eplan.EplApi.Base.Settings oSettings =
            new Eplan.EplApi.Base.Settings();

        int intSetting = oSettings.GetNumericSetting(
            "USER.MF.PREVIEW.MINCOLWIDTH",
            0
            );

        MessageBox.Show("Mindestbreite der Kacheln in der Vorschau: "
            + intSetting.ToString());

        return;
    }

}