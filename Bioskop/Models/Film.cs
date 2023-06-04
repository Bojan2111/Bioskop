namespace Bioskop.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Reziser { get; set; }
        public string Glumci { get; set; }
        public string Zanrovi { get; set; }
        public int Trajanje { get; set; }
        public string Distributer { get; set; }
        public string ZemljaPorekla { get; set; }
        public int GodinaProizvodnje { get; set; }
        public string Opis { get; set; }
    }
}
