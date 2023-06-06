using Bioskop.Models.Login;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bioskop.Models
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<TipProjekcije> TipoviProjekcije { get; set; }
        public DbSet<Sala> Sale { get; set; }
        public DbSet<Sediste> Sedista { get; set; }
        public DbSet<Korisnik> Korisnici { get; set; }
        public DbSet<Film> Filmovi { get; set; }
        public DbSet<Projekcija> Projekcije { get; set; }
        public DbSet<Karta> Karte { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TipProjekcije>().HasData(
                new TipProjekcije() { Id = 1, Naziv = "2D" },
                new TipProjekcije() { Id = 2, Naziv = "3D" },
                new TipProjekcije() { Id = 3, Naziv = "4D" }
            );

            builder.Entity<Sala>().HasData(
                new Sala() { Id = 1, Naziv = "Mala sala" },
                new Sala() { Id = 2, Naziv = "Velika sala" },
                new Sala() { Id = 3, Naziv = "Ultimate sala" }
            );

            builder.Entity<Sediste>().HasData(
                new Sediste() { Id = 1, Broj = 1, SalaId = 1 },
                new Sediste() { Id = 2, Broj = 2, SalaId = 1 },
                new Sediste() { Id = 3, Broj = 3, SalaId = 1 },
                new Sediste() { Id = 4, Broj = 4, SalaId = 1 },
                new Sediste() { Id = 5, Broj = 5, SalaId = 1 },
                new Sediste() { Id = 6, Broj = 6, SalaId = 1 },
                new Sediste() { Id = 7, Broj = 7, SalaId = 1 },
                new Sediste() { Id = 8, Broj = 8, SalaId = 1 },
                new Sediste() { Id = 9, Broj = 9, SalaId = 1 },
                new Sediste() { Id = 10, Broj = 10, SalaId = 1 },
                new Sediste() { Id = 11, Broj = 1, SalaId = 2 },
                new Sediste() { Id = 12, Broj = 2, SalaId = 2 },
                new Sediste() { Id = 13, Broj = 3, SalaId = 2 },
                new Sediste() { Id = 14, Broj = 4, SalaId = 2 },
                new Sediste() { Id = 15, Broj = 5, SalaId = 2 },
                new Sediste() { Id = 16, Broj = 6, SalaId = 2 },
                new Sediste() { Id = 17, Broj = 7, SalaId = 2 },
                new Sediste() { Id = 18, Broj = 8, SalaId = 2 },
                new Sediste() { Id = 19, Broj = 9, SalaId = 2 },
                new Sediste() { Id = 20, Broj = 10, SalaId = 2 },
                new Sediste() { Id = 21, Broj = 11, SalaId = 2 },
                new Sediste() { Id = 22, Broj = 12, SalaId = 2 },
                new Sediste() { Id = 23, Broj = 13, SalaId = 2 },
                new Sediste() { Id = 24, Broj = 14, SalaId = 2 },
                new Sediste() { Id = 25, Broj = 15, SalaId = 2 },
                new Sediste() { Id = 26, Broj = 1, SalaId = 3 },
                new Sediste() { Id = 27, Broj = 2, SalaId = 3 },
                new Sediste() { Id = 28, Broj = 3, SalaId = 3 },
                new Sediste() { Id = 29, Broj = 4, SalaId = 3 },
                new Sediste() { Id = 30, Broj = 5, SalaId = 3 },
                new Sediste() { Id = 31, Broj = 6, SalaId = 3 },
                new Sediste() { Id = 32, Broj = 7, SalaId = 3 },
                new Sediste() { Id = 33, Broj = 8, SalaId = 3 },
                new Sediste() { Id = 34, Broj = 9, SalaId = 3 },
                new Sediste() { Id = 35, Broj = 10, SalaId = 3 },
                new Sediste() { Id = 36, Broj = 11, SalaId = 3 },
                new Sediste() { Id = 37, Broj = 12, SalaId = 3 },
                new Sediste() { Id = 38, Broj = 13, SalaId = 3 },
                new Sediste() { Id = 39, Broj = 14, SalaId = 3 },
                new Sediste() { Id = 40, Broj = 15, SalaId = 3 },
                new Sediste() { Id = 41, Broj = 16, SalaId = 3 },
                new Sediste() { Id = 42, Broj = 17, SalaId = 3 },
                new Sediste() { Id = 43, Broj = 18, SalaId = 3 },
                new Sediste() { Id = 44, Broj = 19, SalaId = 3 },
                new Sediste() { Id = 45, Broj = 20, SalaId = 3 }
            );

            base.OnModelCreating(builder);
        }
    }
}
