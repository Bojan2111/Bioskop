using System.Collections.Generic;

namespace Bioskop.Models.DTOs
{
    public class SalaDTO
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public List<TipProjekcije> TipoviProjekcije { get; set; }
    }
}
