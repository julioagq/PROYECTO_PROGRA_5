using Microsoft.AspNetCore.Mvc;
using PROYECTO_PROGRA_5.Models;

namespace PROYECTO_PROGRA_5.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CinesController : ControllerBase
    {
        private readonly List<Cine> _cines = new()
        {
            new Cine
            {
                Id = 1,
                Nombre = "Cine Central",
                Ubicacion = "San José",
                Salas = new List<Sala>
                {
                    new Sala
                    {
                        Id = 1,
                        Nombre = "Sala 1",
                        Capacidad = 100
                    },
                    new Sala
                    {
                        Id = 2,
                        Nombre = "Sala 2",
                        Capacidad = 80
                    }
                }
            },
            new Cine
            {
                Id = 2,
                Nombre = "Cine Plaza",
                Ubicacion = "Heredia",
                Salas = new List<Sala>
                {
                    new Sala
                    {
                        Id = 3,
                        Nombre = "Sala 1",
                        Capacidad = 120
                    }
                }
            }
        };

        [HttpGet]
        public ActionResult<List<Cine>> ObtenerCines()
        {
            return Ok(_cines);
        }
    }
}
