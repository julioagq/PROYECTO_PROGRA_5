using Microsoft.AspNetCore.Mvc;
using PROYECTO_PROGRA_5.Models;

namespace PROYECTO_PROGRA_5.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeliculasController : ControllerBase
    {
        private readonly List<Pelicula> _peliculas = new()
        {
            new Pelicula
            {
                Id = 1,
                Titulo = "Avengers",
                Genero = "Acción",
                DuracionMinutos = 143
            },
            new Pelicula
            {
                Id = 2,
                Titulo = "Interestelar",
                Genero = "Ciencia ficción",
                DuracionMinutos = 169
            },
            new Pelicula
            {
                Id = 3,
                Titulo = "Toy Story",
                Genero = "Animación",
                DuracionMinutos = 81
            }
        };

        [HttpGet]
        public ActionResult<List<Pelicula>> ObtenerPeliculas()
        {
            return Ok(_peliculas);
        }
    }
}
