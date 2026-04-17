using projeto_carlos.Models;
using projeto_carlos.Models.Entities;
using projeto_carlos.Repositories.Interfaces;
using VitaFlow.Data;
using VitaFlow.Repositories.Base;

namespace projeto_carlos.Repositories
{
    public class AppointmentRepository : RepositoryBase<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(AppDbContext context) : base(context)
        {
        }
    }
}
