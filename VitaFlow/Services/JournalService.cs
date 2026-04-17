using projeto_carlos.Models.Entities;
using projeto_carlos.Repositories.Interfaces;
using projeto_carlos.Services.Interfaces;
using VitaFlow.Services.Base;

namespace projeto_carlos.Services
{
    public class JournalService : ServiceBase<Journal>, IJournalService
    {
        public JournalService(IJournalRepository repository) : base(repository)
        {
        }
    }
}
