using Bioskop.Models.Login;
using System;
using System.ComponentModel.DataAnnotations;

namespace Bioskop.Models
{
    public class Karta
    {
        public int Id { get; set; }
        [Required]
        public int ProjekcijaId { get; set; }
        public Projekcija Projekcija { get; set; }
        [Required]
        public int SedisteId { get; set; }
        public Sediste Sediste { get; set; }
        [Required]
        public DateTime VremeProdaje { get; set; }
        [Required]
        public string KorisnikId { get; set; }
        public ApplicationUser Korisnik { get; set; }
    }
}
