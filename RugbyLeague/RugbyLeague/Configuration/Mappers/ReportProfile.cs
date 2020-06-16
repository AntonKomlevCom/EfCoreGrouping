using AutoMapper;
using RugbyLeague.Data.Entities;
using RugbyLeague.Models.Reports.DataByDivision;
using System.Linq;

namespace RugbyLeague.Configuration.Mappers
{
    public class ReportProfile : Profile
    {
        public ReportProfile()
        {
            CreateMap<IGrouping<DataByDivisionGrouping, Team>, DataByDivisionModel>()
                .ForMember(dest => dest.Name, options => options.MapFrom(orig => orig.Key.Name))
                .ForMember(dest => dest.Description, options => options.MapFrom(orig => orig.Key.Description))
                .ForMember(dest => dest.ZipCode, options => options.MapFrom(orig => orig.Key.ZipCode))
                .ForMember(dest => dest.TeamsCount, options => options.MapFrom(orig => orig.Count()));            
        }
    }
}
