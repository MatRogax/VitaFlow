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
            EButtonVariant.Primary => "bg-blue-500 hover:bg-blue-600 text-white shadow-sm",
            EButtonVariant.Secondary => "bg-blue-50 hover:bg-blue-100 text-blue-600",
            EButtonVariant.Outline => "border border-gray-300 bg-transparent hover:bg-gray-50 text-gray-700",
            EButtonVariant.Text => "bg-transparent hover:underline text-blue-500 p-0",
            EButtonVariant.Ghost => "bg-transparent text-gray-500 hover:text-gray-800 p-0",
            _ => string.Empty
        };
    }
}