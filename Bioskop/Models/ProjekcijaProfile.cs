using AutoMapper;
using Bioskop.Models.DTOs;
using Bioskop.Models.Login;
using System;
using System.Net.Sockets;

namespace Bioskop.Models
{
    public class ProjekcijaProfile : Profile
    {
        public ProjekcijaProfile()
        {
            CreateMap<Projekcija, ProjekcijaDTO>()
                .ForMember(dest => dest.FilmNaziv, opt => opt.MapFrom(src => src.Film.Naziv))
                .ForMember(dest => dest.TipProjekcijeNaziv, opt => opt.MapFrom(src => src.TipProjekcije.Naziv))
                .ForMember(dest => dest.SalaNaziv, opt => opt.MapFrom(src => src.Sala.Naziv))
                .ForMember(dest => dest.Admin, opt => opt.MapFrom(src => src.Admin.UserName));
        }
    }
}
