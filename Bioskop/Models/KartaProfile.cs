using AutoMapper;
using Bioskop.Models.DTOs;
using System;

namespace Bioskop.Models
{
    public class KartaProfile : Profile
    {
        public KartaProfile()
        {
            CreateMap<Karta, KartaDTO>()
                .ForMember(dest => dest.FilmNaziv, opt => opt.MapFrom(src => src.Projekcija.Film.Naziv))
                .ForMember(dest => dest.TipProjekcijeNaziv, opt => opt.MapFrom(src => src.Projekcija.TipProjekcije.Naziv))
                .ForMember(dest => dest.SalaNaziv, opt => opt.MapFrom(src => src.Projekcija.Sala.Naziv))
                .ForMember(dest => dest.ProjekcijaCena, opt => opt.MapFrom(src => src.Projekcija.CenaKarte))
                .ForMember(dest => dest.SedisteBroj, opt => opt.MapFrom(src => src.Sediste.Broj))
                .ForMember(dest => dest.Korisnik, opt => opt.MapFrom(src => src.Korisnik.UserName));
        }
    }
}
