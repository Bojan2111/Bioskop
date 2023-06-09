using Bioskop.Interfaces;
using Bioskop.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Bioskop.Repository
{
    public class KartaRepository : IKartaRepository
    {
        private readonly AppDbContext _context;

        public KartaRepository(AppDbContext context)
        {
            this._context = context;
        }
        public void Add(Karta karta)
        {
            _context.Karte.Add(karta);
            _context.SaveChanges();
        }

        public void Delete(Karta karta)
        {
            _context.Karte.Remove(karta);
            _context.SaveChanges();
        }

        public IQueryable<Karta> GetAll()
        {
            return _context.Karte;
        }

        public Karta GetById(int id)
        {
            return _context.Karte.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Karta karta)
        {
            _context.Entry(karta).State = EntityState.Modified;

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
