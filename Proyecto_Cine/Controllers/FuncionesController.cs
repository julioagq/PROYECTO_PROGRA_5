using Microsoft.AspNetCore.Mvc;
using PROYECTO_PROGRA_5.Models;

namespace PROYECTO_PROGRA_5.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FuncionesController : ControllerBase
    {
        private readonly List<Funcion> _funciones = new()
        {
            new Funcion
            {
                Id = 1,
                PeliculaId = 1,
                CineId = 1,
                SalaId = 1,
                FechaHora = new DateTime(2026, 10, 10, 19, 30, 0)
            },
            new Funcion
            {
                Id = 2,
                PeliculaId = 1,
                CineId = 1,
                SalaId = 2,
                FechaHora = new DateTime(2026, 10, 10, 21, 30, 0)
            },
            new Funcion
            {
                Id = 3,
                PeliculaId = 2,
                CineId = 2,
                SalaId = 3,
                FechaHora = new DateTime(2026, 10, 11, 18, 00, 0)
            }
        };

        [HttpGet]
        public ActionResult<List<Funcion>> ObtenerFunciones()
        {
            return Ok(_funciones);
        }
    }
}
