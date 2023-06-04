using System;

namespace Bioskop.Models
{
    public class Projekcija
    {
        public int Id { get; set; }
        public int FilmId { get; set; }
        public Film Film { get; set; }
        public int TipProjekcijeId { get; set; }
        public TipProjekcije TipProjekcije { get; set; }
        public int SalaId { get; set; }
        public Sala Sala { get; set; }
        public DateTime VremePrikazivanja { get; set; }
        public decimal CenaKarte { get; set; }
        public int AdministratorId { get; set; }
        public Korisnik Administrator { get; set; }
    }
}
