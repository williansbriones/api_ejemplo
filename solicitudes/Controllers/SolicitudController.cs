using Microsoft.AspNetCore.Mvc;
using solicitudes.Servicio;
using solicitudes.Servicio.Implements;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace solicitudes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolicitudController : ControllerBase
    {
        IcrudSolicitud solicitud = new  SolicitudesService();

        // GET api/<SolicitudController>/5
        [HttpGet("{id_solicitud}")]
        public Modelos.Solcitud Get(int id_solicitud)
        {
            return solicitud.ConsultarSolicitud(id_solicitud);
        }



    }
}
