using Bioskop.Interfaces;
using Bioskop.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Bioskop.Repository
{
    public class KorisnikRepository : IKorisnikRepository
    {
        private readonly AppDbContext _context;

        public KorisnikRepository(AppDbContext context)
        {
            this._context = context;
        }
        public void Add(Korisnik korisnik)
        {
            _context.Korisnici.Add(korisnik);
            _context.SaveChanges();
        }

        public void Delete(Korisnik korisnik)
        {
            _context.Korisnici.Remove(korisnik);
            _context.SaveChanges();
        }

        public IQueryable<Korisnik> GetAll()
        {
            return _context.Korisnici;
        }

        public Korisnik GetById(int id)
        {
            return _context.Korisnici.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Korisnik korisnik)
        {
            _context.Entry(korisnik).State = EntityState.Modified;

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
