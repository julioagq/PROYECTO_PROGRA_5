using Microsoft.AspNetCore.Mvc;
using PROYECTO_PROGRA_5.Models;
using PROYECTO_PROGRA_5.Services;

namespace PROYECTO_PROGRA_5.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ButacasController : ControllerBase
    {
        private readonly ButacaService _butacaService;

        public ButacasController(ButacaService butacaService)
        {
            _butacaService = butacaService;
        }

        [HttpGet]
        public ActionResult<List<Butaca>> ObtenerButacas()
        {
            return Ok(_butacaService.ObtenerButacas());
        }

        [HttpPost("{id}/bloquear")]
        public async Task<IActionResult> BloquearButaca(int id)
        {
            var bloqueada = await _butacaService.BloquearButaca(id);

            if (!bloqueada)
            {
                return Conflict(new
                {
                    mensaje = "La butaca no existe o ya está bloqueada."
                });
            }

            return Ok(new
            {
                mensaje = "Butaca bloqueada durante 10 minutos."
            });
        }
    }
}
