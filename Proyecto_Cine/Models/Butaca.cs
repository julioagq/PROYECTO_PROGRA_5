namespace PROYECTO_PROGRA_5.Models
{
    public class Butaca
    {
        public int Id { get; set; }

        public int SalaId { get; set; }

        public string Fila { get; set; } = string.Empty;

        public int Numero { get; set; }

        public bool EstaBloqueada { get; set; }

        public DateTime? BloqueadaHasta { get; set; }
    }
}
