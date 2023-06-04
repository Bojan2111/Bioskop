namespace Bioskop.Models
{
    public class Sediste
    {
        public int Id { get; set; }
        public int Broj { get; set; }
        public int SalaId { get; set; }
        public Sala Sala { get; set; }
    }
}
