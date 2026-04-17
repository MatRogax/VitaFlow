using projeto_carlos.Models.Entities;
using projeto_carlos.Models.ViewModels;

namespace projeto_carlos.Services.Interfaces
{
    public interface IAuthService
    {
        Task<User?> LoginAsync(LoginViewModel model);
        Task<User?> RegisterAsync(RegisterViewModel model);
    }
}
