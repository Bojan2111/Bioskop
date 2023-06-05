using System.ComponentModel.DataAnnotations;

namespace Bioskop.Models
{
    public class Sala
    {
        public int Id { get; set; }
        [Required]
        public string Naziv { get; set; }
    }
}
