using projeto_carlos.Enums;

namespace projeto_carlos.Common.Extensions
{
    public static class ENotificationTypeExtensions
    {
        public static string GetStyles(this ENotificationType type)
        {
            return type switch
            {
                ENotificationType.Success => "bg-emerald-50 border-emerald-100 text-emerald-700 dark:bg-emerald-900/20 dark:border-emerald-900/40 dark:text-emerald-400",
                ENotificationType.Error => "bg-rose-50 border-rose-100 text-rose-700 dark:bg-rose-900/20 dark:border-rose-900/40 dark:text-rose-400",
                ENotificationType.Warning => "bg-amber-50 border-amber-100 text-amber-700 dark:bg-amber-900/20 dark:border-amber-900/40 dark:text-amber-400",
                ENotificationType.Info => "bg-sky-50 border-sky-100 text-sky-700 dark:bg-sky-900/20 dark:border-sky-900/40 dark:text-sky-400",
                _ => "bg-slate-50 border-slate-100 text-slate-700"
            };
        }

        public static string GetIcon(this ENotificationType type)
        {
            return type switch
            {
                ENotificationType.Success => "check_circle",
                ENotificationType.Error => "error",
                ENotificationType.Warning => "warning",
                ENotificationType.Info => "info",
                _ => "notifications"
            };
        }

        public static string GetAccentColor(this ENotificationType type)
        {
            return type switch
            {
                ENotificationType.Success => "bg-emerald-500",
                ENotificationType.Error => "bg-rose-500",
                ENotificationType.Warning => "bg-amber-500",
                ENotificationType.Info => "bg-sky-500",
                _ => "bg-slate-500"
            };
        }
    }
}
