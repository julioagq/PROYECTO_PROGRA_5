namespace PROYECTO_PROGRA_5.Models
{
    public class Cine
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Ubicacion { get; set; } = string.Empty;

        public List<Sala> Salas { get; set; } = new();
    }
}

