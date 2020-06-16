using AutoMapper;
using RugbyLeague.Data.Entities;
using RugbyLeague.Models;

namespace RugbyLeague.Configuration.Mappers
{
    public class TeamProfile : Profile
    {
        public TeamProfile()
        {
            CreateMap<Team, TeamModel>()
                .ForMember(dest => dest.FullAddress, opt => opt.MapFrom(src => $"{src.Address} {src.City}, {src.State} {src.ZipCode}"));
        }        
    }
}
