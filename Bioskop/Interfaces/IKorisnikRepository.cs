using Bioskop.Models;
using System.Linq;

namespace Bioskop.Interfaces
{
    public interface IKorisnikRepository
    {
        IQueryable<Korisnik> GetAll();
        Korisnik GetById(int id);
        void Add(Korisnik korisnik);
        void Update(Korisnik korisnik);
        void Delete(Korisnik korisnik);
    }
}
