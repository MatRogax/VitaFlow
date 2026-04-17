using projeto_carlos.Models.Entities;
using projeto_carlos.Repositories.Interfaces;
using VitaFlow.Data;
using VitaFlow.Repositories.Base;

namespace projeto_carlos.Repositories
{
    public class JournalRepository : RepositoryBase<Journal>, IJournalRepository
    {
        public JournalRepository(AppDbContext context) : base(context)
        {
        }
    }
}
