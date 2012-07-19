using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class Class
{
    [DeclareRegister]
    public void Register()
    {
        Eplan.EplApi.Base.Settings oSettings =
            new Eplan.EplApi.Base.Settings();

        oSettings.SetBoolSetting(
            "USER.EnfMVC.ContextMenuSetting.ShowIdentifier",
            true,
            0
            );

        MessageBox.Show("Kontextmenü-ID: sichtbar");

        return;
    }

    [DeclareUnregister]
    public void UnRegister()
    {
        Eplan.EplApi.Base.Settings oSettings =
            new Eplan.EplApi.Base.Settings();

        oSettings.SetBoolSetting(
            "USER.EnfMVC.ContextMenuSetting.ShowIdentifier",
            false,
            0
            );

        MessageBox.Show("Kontextmenü-ID: unsichtbar");

        return;
    }
}



