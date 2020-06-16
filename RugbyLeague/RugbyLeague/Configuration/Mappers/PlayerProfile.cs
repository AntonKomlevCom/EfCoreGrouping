using AutoMapper;
using RugbyLeague.Data.Entities;
using RugbyLeague.Models;

namespace RugbyLeague.Configuration.Mappers
{
    public class PlayerProfile : Profile
    {
        public PlayerProfile()
        {
            CreateMap<Player, PlayerModel>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"));
        }
    }
}
