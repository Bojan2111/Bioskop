using System;

namespace Bioskop.Models
{
    public class Karta
    {
        public int Id { get; set; }
        public int ProjekcijaId { get; set; }
        public Projekcija Projekcija { get; set; }
        public int SedisteId { get; set; }
        public Sediste Sediste { get; set; }
        public DateTime VremeProdaje { get; set; }
        public int KorisnikId { get; set; }
        public Korisnik Korisnik { get; set; }
    }
}
