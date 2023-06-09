using Bioskop.Models;
using System.Linq;

namespace Bioskop.Interfaces
{
    public interface IKartaRepository
    {
        IQueryable<Karta> GetAll();
        Karta GetById(int id);
        void Add(Karta karta);
        void Update(Karta karta);
        void Delete(Karta karta);
    }
}
