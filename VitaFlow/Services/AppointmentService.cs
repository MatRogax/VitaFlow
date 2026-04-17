using projeto_carlos.Models.Entities;
using projeto_carlos.Repositories.Interfaces;
using projeto_carlos.Services.Interfaces;
using VitaFlow.Services.Base;

namespace projeto_carlos.Services
{
    public class AppointmentService : ServiceBase<Appointment>, IAppointmentService
    {
        public AppointmentService(IAppointmentRepository repository) : base(repository)
        {
        }
    }
}
