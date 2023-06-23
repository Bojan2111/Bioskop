using Bioskop.Models.Login;
using System.ComponentModel.DataAnnotations;
using System;

namespace Bioskop.Models.DTOs
{
    public class KartaDTO
    {
        public string FilmNaziv { get; set; }
        public string TipProjekcijeNaziv { get; set; }
        public string SalaNaziv { get; set; }
        public decimal ProjekcijaCena { get; set; }
        public string SedisteBroj { get; set; }
        public DateTime VremeProdaje { get; set; }
        public string Korisnik { get; set; }
    }
}
