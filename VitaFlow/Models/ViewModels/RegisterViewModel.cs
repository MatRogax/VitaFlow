using projeto_carlos.Enums;

namespace projeto_carlos.Models.ViewModels;

public class RegisterViewModel
{
    public EProfileType Perfil { get; set; } = EProfileType.Patient; 
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Senha { get; set; } = string.Empty;
    public string ConfirmarSenha { get; set; } = string.Empty;
    public bool AceitouTermos { get; set; }
}