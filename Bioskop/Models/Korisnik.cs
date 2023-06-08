using System;
using System.ComponentModel.DataAnnotations;

namespace Bioskop.Models
{
    public class Korisnik
    {
        public int Id { get; set; }
        [Required]
        public string KorisnickoIme { get; set; }
        [Required]
        public string Lozinka { get; set; }
        [Required]
        public DateTime DatumRegistracije { get; set; }
        [Required]
        public string Uloga { get; set; }
        public bool Obrisan { get; set; } = false;
    }
}
