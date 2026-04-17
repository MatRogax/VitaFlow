using projeto_carlos.Models.Entities;
using projeto_carlos.Models.ViewModels;
using projeto_carlos.Repositories.Interfaces;
using projeto_carlos.Services.Interfaces;
using VitaFlow.Common.Helpers;

namespace projeto_carlos.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;

        public AuthService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User?> LoginAsync(LoginViewModel model)
        {
            var user = await _userRepository.GetByEmailAsync(model.Email);
            
            if (user == null)
                return null;

            if (PasswordHasher.VerifyPassword(model.Password, user.PasswordHash))
                return user;

            return null;
        }

        public async Task<User?> RegisterAsync(RegisterViewModel model)
        {
            var existing = await _userRepository.GetByEmailAsync(model.Email);
            if (existing != null)
                return null;

            var user = new User
            {
                Name = model.Nome,
                Email = model.Email,
                PasswordHash = PasswordHasher.HashPassword(model.Senha),
                ProfileType = model.Perfil,
                CreatedAt = DateTime.UtcNow
            };

            await _userRepository.AddAsync(user);
            await _userRepository.SaveChangesAsync();

            return user;
        }
    }
}
