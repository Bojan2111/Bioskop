using Bioskop.Models.Login;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

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
                new Sala() { Id = 1, Naziv = "Mala sala - 3D i 4D" },
                new Sala() { Id = 2, Naziv = "Velika sala - 2D i 3D" },
                new Sala() { Id = 3, Naziv = "Ultimate sala - sve" }
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

            builder.Entity<Film>().HasData(
                new Film()
                {
                    Id = 1,
                    Naziv = "Film 1",
                    Reziser = "Reziser 1",
                    Glumci = "Glumci 1",
                    Zanrovi = "Zanrovi 1",
                    Trajanje = 120,
                    Distributer = "Distr 1",
                    ZemljaPorekla = "Zemlja 1",
                    GodinaProizvodnje = 1985,
                    Opis = "Opis 1"
                },
                new Film()
                {
                    Id = 2,
                    Naziv = "Film 2",
                    Reziser = "Reziser 2",
                    Glumci = "Glumci 2",
                    Zanrovi = "Zanrovi 2",
                    Trajanje = 110,
                    Distributer = "Distr 2",
                    ZemljaPorekla = "Zemlja 2",
                    GodinaProizvodnje = 1984,
                    Opis = "Opis 2"
                },
                new Film()
                {
                    Id = 3,
                    Naziv = "Spaceballs",
                    Reziser = "Mel Brooks",
                    Glumci = "Mel Brooks, John Candy, Rick Moranis, Bill Pullman, Daphne Zuniga",
                    Zanrovi = "Sci-Fi, Komedija, Avantura",
                    Trajanje = 96,
                    Distributer = "Metro Goldwyn Mayer",
                    ZemljaPorekla = "USA",
                    GodinaProizvodnje = 1987,
                    Opis = "Opis"
                },
                new Film()
                {
                    Id = 4,
                    Naziv = "Film 4",
                    Reziser = "Reziser 4",
                    Glumci = "Glumci 4",
                    Zanrovi = "Zanrovi 4",
                    Trajanje = 90,
                    Distributer = "Distr 4",
                    ZemljaPorekla = "Zemlja 4",
                    GodinaProizvodnje = 1991,
                    Opis = "Opis 4"
                },
                new Film()
                {
                    Id = 5,
                    Naziv = "Film 5",
                    Reziser = "Reziser 5",
                    Glumci = "Glumci 5",
                    Zanrovi = "Zanrovi 5",
                    Trajanje = 98,
                    Distributer = "Distr 5",
                    ZemljaPorekla = "Zemlja 5",
                    GodinaProizvodnje = 2001,
                    Opis = "Opis 5"
                }
            );

            builder.Entity<Korisnik>().HasData(
                new Korisnik()
                {
                    Id = 1,
                    KorisnickoIme = "Administrator",
                    Lozinka = "Lozinka",
                    DatumRegistracije = new DateTime(2021, 11, 21),
                    Uloga = "Administrator"
                },
                new Korisnik()
                {
                    Id = 2,
                    KorisnickoIme = "Korisnik1",
                    Lozinka = "Lozinka1",
                    DatumRegistracije = new DateTime(2021, 11, 23),
                    Uloga = "Korisnik"
                },
                new Korisnik()
                {
                    Id = 3,
                    KorisnickoIme = "Korisnik2",
                    Lozinka = "Lozinka2",
                    DatumRegistracije = new DateTime(2021, 12, 21),
                    Uloga = "Korisnik"
                }
            );

            builder.Entity<Projekcija>().HasData(
                new Projekcija()
                {
                    Id = 1,
                    FilmId = 3,
                    TipProjekcijeId = 1,
                    SalaId = 2,
                    VremePrikazivanja = new DateTime(2023, 6, 13, 11, 30, 0),
                    CenaKarte = 350m,
                    AdministratorId = 1,
                },
                new Projekcija()
                {
                    Id = 2,
                    FilmId = 1,
                    TipProjekcijeId = 2,
                    SalaId = 1,
                    VremePrikazivanja = new DateTime(2023, 6, 7, 10, 45, 0),
                    CenaKarte = 400m,
                    AdministratorId = 1,
                },
                new Projekcija()
                {
                    Id = 3,
                    FilmId = 5,
                    TipProjekcijeId = 3,
                    SalaId = 3,
                    VremePrikazivanja = new DateTime(2023, 6, 14, 13, 15, 0),
                    CenaKarte = 550m,
                    AdministratorId = 1,
                },
                new Projekcija()
                {
                    Id = 4,
                    FilmId = 2,
                    TipProjekcijeId = 2,
                    SalaId = 1,
                    VremePrikazivanja = new DateTime(2023, 6, 14, 16, 30, 0),
                    CenaKarte = 400m,
                    AdministratorId = 1,
                },
                new Projekcija()
                {
                    Id = 5,
                    FilmId = 2,
                    TipProjekcijeId = 3,
                    SalaId = 1,
                    VremePrikazivanja = new DateTime(2023, 6, 14, 18, 45, 0),
                    CenaKarte = 450m,
                    AdministratorId = 1,
                }
            );

            builder.Entity<Karta>().HasData(
                new Karta()
                {
                    Id = 1,
                    ProjekcijaId = 1,
                    SedisteId = 11,
                    VremeProdaje = new DateTime(2023, 5, 26, 12, 35, 13),
                    KorisnikId = 2,
                },
                new Karta()
                {
                    Id = 2,
                    ProjekcijaId = 5,
                    SedisteId = 1,
                    VremeProdaje = new DateTime(2023, 5, 26, 9, 38, 0),
                    KorisnikId = 3,
                },
                new Karta()
                {
                    Id = 3,
                    ProjekcijaId = 2,
                    SedisteId = 8,
                    VremeProdaje = new DateTime(2023, 5, 27, 18, 45, 33),
                    KorisnikId = 3,
                },
                new Karta()
                {
                    Id = 4,
                    ProjekcijaId = 4,
                    SedisteId = 2,
                    VremeProdaje = new DateTime(2023, 5, 27, 19, 11, 56),
                    KorisnikId = 2,
                },
                new Karta()
                {
                    Id = 5,
                    ProjekcijaId = 1,
                    SedisteId = 21,
                    VremeProdaje = new DateTime(2023, 5, 27, 19, 15, 43),
                    KorisnikId = 3,
                },
                new Karta()
                {
                    Id = 6,
                    ProjekcijaId = 4,
                    SedisteId = 3,
                    VremeProdaje = new DateTime(2023, 5, 28, 10, 14, 53),
                    KorisnikId = 2,
                },
                new Karta()
                {
                    Id = 7,
                    ProjekcijaId = 3,
                    SedisteId = 33,
                    VremeProdaje = new DateTime(2023, 5, 28, 11, 24, 31),
                    KorisnikId = 3,
                }
            );

            base.OnModelCreating(builder);
        }
    }
}
