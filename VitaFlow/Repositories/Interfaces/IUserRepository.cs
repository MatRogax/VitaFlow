using projeto_carlos.Models.Entities;
using VitaFlow.Common.Interfaces;

namespace projeto_carlos.Repositories.Interfaces
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        Task<User?> GetByEmailAsync(string email);
    }
}
