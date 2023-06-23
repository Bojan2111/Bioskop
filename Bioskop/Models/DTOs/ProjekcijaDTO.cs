using Bioskop.Models.Login;
using System.ComponentModel.DataAnnotations;
using System;

namespace Bioskop.Models.DTOs
{
    public class ProjekcijaDTO
    {
        public string FilmNaziv { get; set; }
        public string TipProjekcijeNaziv { get; set; }
        public string SalaNaziv { get; set; }
        public DateTime VremePrikazivanja { get; set; }
        public decimal CenaKarte { get; set; }
        public string Admin { get; set; }
    }
}
