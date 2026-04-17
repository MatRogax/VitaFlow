namespace projeto_carlos.Enums;

public enum ESettingsSection
{
    Perfil,
    Notifications,
    Security,
    Privacy
}

public static class SettingsSectionExtensions
{
    public static string ToIcon(this ESettingsSection section)
    {
        return section switch
        {
            ESettingsSection.Perfil => "person",
            ESettingsSection.Notifications => "notifications",
            ESettingsSection.Security => "security",
            ESettingsSection.Privacy => "lock",
            _ => "settings"
        };
    }

    public static string ToDisplayName(this ESettingsSection section)
    {
        return section switch
        {
            ESettingsSection.Perfil => "Perfil",
            ESettingsSection.Notifications => "Notificações",
            ESettingsSection.Security => "Segurança",
            ESettingsSection.Privacy => "Privacidade",
            _ => section.ToString()
        };
    }
}
