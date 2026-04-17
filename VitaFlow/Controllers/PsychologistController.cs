using Microsoft.AspNetCore.Mvc;
using projeto_carlos.Models.Entities;
using projeto_carlos.Services.Interfaces;
using VitaFlow.Controllers.Base;

namespace projeto_carlos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PsychologistController : BaseController<Psychologist>
    {
        public PsychologistController(IPsychologistService service) : base(service)
        {
        }
    }
}