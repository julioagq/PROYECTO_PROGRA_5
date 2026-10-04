using PROYECTO_PROGRA_5.Models;

namespace PROYECTO_PROGRA_5.Services
{
    public class ButacaService
    {
        private readonly List<Butaca> _butacas = new()
        {
            new Butaca { Id = 1, SalaId = 1, Fila = "A", Numero = 1 },
            new Butaca { Id = 2, SalaId = 1, Fila = "A", Numero = 2 },
            new Butaca { Id = 3, SalaId = 1, Fila = "A", Numero = 3 },
            new Butaca { Id = 4, SalaId = 1, Fila = "A", Numero = 4 },
            new Butaca { Id = 5, SalaId = 1, Fila = "A", Numero = 5 }
        };

        public List<Butaca> ObtenerButacas()
        {
            LiberarButacasVencidas();

            return _butacas;
        }

        public bool BloquearButaca(int id)
        {
            LiberarButacasVencidas();

            var butaca = _butacas.FirstOrDefault(b => b.Id == id);

            if (butaca == null || butaca.EstaBloqueada)
                return false;

            butaca.EstaBloqueada = true;
            butaca.BloqueadaHasta = DateTime.Now.AddMinutes(10);

            return true;
        }

        private void LiberarButacasVencidas()
        {
            foreach (var butaca in _butacas)
            {
                if (butaca.EstaBloqueada &&
                    butaca.BloqueadaHasta <= DateTime.Now)
                {
                    butaca.EstaBloqueada = false;
                    butaca.BloqueadaHasta = null;
                }
            }
        }
    }
}
