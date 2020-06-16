using AutoMapper;
using RugbyLeague.Data.Entities;
using RugbyLeague.Models;

namespace RugbyLeague.Configuration.Mappers
{
    public class DivisionProfile : Profile
    {
        public DivisionProfile()
        {
            CreateMap<Division, DivisionModel>();
        }
    }
}
