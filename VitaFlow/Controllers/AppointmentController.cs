using Microsoft.AspNetCore.Mvc;
using projeto_carlos.Models.Entities;
using projeto_carlos.Services.Interfaces;
using VitaFlow.Controllers.Base;

namespace VitaFlow.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentController : BaseController<Appointment>
    {
        public AppointmentController(IAppointmentService service) : base(service)
        {
        }
    }
}