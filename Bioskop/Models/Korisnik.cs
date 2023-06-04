using System;

namespace Bioskop.Models
{
    public class Korisnik
    {
        public int Id { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public DateTime DatumRegistracije { get; set; }
        public string Uloga { get; set; }
    }
}
