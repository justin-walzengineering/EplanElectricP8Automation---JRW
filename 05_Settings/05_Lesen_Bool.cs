using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class Class
{
    [Start]
    public void Function()
    {
        Eplan.EplApi.Base.Settings oSettings =
            new Eplan.EplApi.Base.Settings();

        bool bolSetting = oSettings.GetBoolSetting(
            "USER.XUserSettingsGui.UseLoginName",
            0
            );

        if (bolSetting)
        {
            MessageBox.Show("Einstellung ist aktiviert.");
        }
        else
        {
            MessageBox.Show("Einstellung ist deaktiviert.");
        }

        return;
    }
}