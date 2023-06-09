using Bioskop.Models;
using System.Collections.Generic;
using System.Linq;

namespace Bioskop.Interfaces
{
    public interface IFilmRepository
    {
        IQueryable<Film> GetAll();
        Film GetById(int id);
        void Add(Film film);
        void Update(Film film);
        void Delete(Film film);
    }
}
