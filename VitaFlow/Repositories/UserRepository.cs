using Microsoft.EntityFrameworkCore;
using projeto_carlos.Models.Entities;
using projeto_carlos.Repositories.Interfaces;
using VitaFlow.Data;
using VitaFlow.Repositories.Base;

namespace projeto_carlos.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<User?> GetByEmailAsync(string email)
        {
            return await _dbSet.FirstOrDefaultAsync(u => u.Email.ToLower() == email.ToLower());
        }
    }
}
