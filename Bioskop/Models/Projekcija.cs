using Bioskop.Models.Login;
using System;
using System.ComponentModel.DataAnnotations;

namespace Bioskop.Models
{
    public class Projekcija
    {
        public int Id { get; set; }
        [Required]
        public int FilmId { get; set; }
        public Film Film { get; set; }
        [Required]
        public int TipProjekcijeId { get; set; }
        public TipProjekcije TipProjekcije { get; set; }
        [Required]
        public int SalaId { get; set; }
        public Sala Sala { get; set; }
        [Required]
        public DateTime VremePrikazivanja { get; set; }
        [Required]
        public decimal CenaKarte { get; set; }
        [Required]
        public string AdministratorId { get; set; }
        public ApplicationUser Admin { get; set; }
        public bool Obrisana { get; set; } = false;
    }
}
