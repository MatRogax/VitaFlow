using projeto_carlos.Models;
using projeto_carlos.Models.Entities;
using projeto_carlos.Repositories.Interfaces;
using VitaFlow.Data;
using VitaFlow.Repositories.Base;

namespace projeto_carlos.Repositories
{
    public class PsychologistRepository : RepositoryBase<Psychologist>, IPsychologistRepository
    {
        public PsychologistRepository(AppDbContext context) : base(context)
        {
        }
    }
}
