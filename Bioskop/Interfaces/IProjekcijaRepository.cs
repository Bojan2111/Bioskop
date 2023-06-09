using Bioskop.Models;
using System.Linq;

namespace Bioskop.Interfaces
{
    public interface IProjekcijaRepository
    {
        IQueryable<Projekcija> GetAll();
        Projekcija GetById(int id);
        void Add(Projekcija projekcija);
        void Update(Projekcija projekcija);
        void Delete(Projekcija projekcija);
    }
}
