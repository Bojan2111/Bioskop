using Bioskop.Interfaces;
using Bioskop.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Bioskop.Repository
{
    public class ProjekcijaRepository : IProjekcijaRepository
    {
        private readonly AppDbContext _context;

        public ProjekcijaRepository(AppDbContext context)
        {
            this._context = context;
        }
        public void Add(Projekcija projekcija)
        {
            _context.Projekcije.Add(projekcija);
            _context.SaveChanges();
        }

        public void Delete(Projekcija projekcija)
        {
            _context.Projekcije.Remove(projekcija);
            _context.SaveChanges();
        }

        public IQueryable<Projekcija> GetAll()
        {
            return _context.Projekcije;
        }

        public Projekcija GetById(int id)
        {
            return _context.Projekcije.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Projekcija projekcija)
        {
            _context.Entry(projekcija).State = EntityState.Modified;

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
