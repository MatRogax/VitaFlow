namespace projeto_carlos.Enums;

public enum EButtonVariant
{
    Primary,    
    Secondary,  
    Outline,    
    Text,
    Ghost
}

public static class ButtonVariantExtensions
{
    public static string ToTailwindClasses(this EButtonVariant variant)
    {
        return variant switch
        {
            EButtonVariant.Primary => "bg-primary hover:bg-primary/90 text-white shadow-sm",
            EButtonVariant.Secondary => "bg-bg-input hover:bg-border-color text-primary dark:text-white",
            EButtonVariant.Outline => "border border-border-color bg-transparent hover:bg-bg-input text-text-main",
            EButtonVariant.Text => "bg-transparent hover:underline text-primary p-0",
            EButtonVariant.Ghost => "bg-transparent text-text-muted hover:text-text-main p-0",
            _ => string.Empty
        };
    }
}