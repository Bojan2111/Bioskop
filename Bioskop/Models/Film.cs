using System.ComponentModel.DataAnnotations;

namespace Bioskop.Models
{
    public class Film
    {
        public int Id { get; set; }
        [Required]
        public string Naziv { get; set; }
        public string Reziser { get; set; }
        public string Glumci { get; set; }
        public string Zanrovi { get; set; }
        [Required]
        [Range(1, 600)]
        public int Trajanje { get; set; }
        [Required]
        public string Distributer { get; set; }
        [Required]
        public string ZemljaPorekla { get; set; }
        [Required]
        [Range(1888, 2100)]
        public int GodinaProizvodnje { get; set; }
        public string Opis { get; set; }
        public bool Obrisan { get; set; } = false;
    }
}
