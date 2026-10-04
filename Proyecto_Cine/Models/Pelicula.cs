namespace PROYECTO_PROGRA_5.Models
{
    public class Pelicula
    {
        public int Id { get; set; }

        public string Titulo { get; set; } = string.Empty;

        public string Genero { get; set; } = string.Empty;

        public int DuracionMinutos { get; set; }
    }
}
