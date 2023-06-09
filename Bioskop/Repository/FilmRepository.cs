using Bioskop.Interfaces;
using Bioskop.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Bioskop.Repository
{
    public class FilmRepository : IFilmRepository
    {
        private readonly AppDbContext _context;

        public FilmRepository(AppDbContext context)
        {
            this._context = context;
        }

        public void Add(Film film)
        {
            _context.Filmovi.Add(film);
            _context.SaveChanges();
        }

        public void Delete(Film film)
        {
            _context.Filmovi.Remove(film);
            _context.SaveChanges();
        }

        public IQueryable<Film> GetAll()
        {
            return _context.Filmovi;
        }

        public Film GetById(int id)
        {
            return _context.Filmovi.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Film film)
        {
            _context.Entry(film).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

        }
    }
}
