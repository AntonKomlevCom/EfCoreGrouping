using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using RugbyLeague.Data.EfStructures;
using RugbyLeague.Models.Reports.DataByDivision;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RugbyLeague.Repositories
{
    public class ReportRepository : IReportRepository
    {
        private readonly RugbyLeagueDbContext _dbContext;
        private readonly IMapper _mapper;

        public ReportRepository(RugbyLeagueDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<DataByDivisionModel>> GetDataByDivision(Guid divisionUid)
        {
            var result = await _dbContext.Team
                .Where(p => p.Division.Uid == divisionUid)
                .GroupBy(g => new DataByDivisionGrouping()
                {
                    Name = g.Division.Name,
                    Description = g.Division.Description,
                    ZipCode = g.ZipCode
                })
                .ProjectTo<DataByDivisionModel>(_mapper.ConfigurationProvider)
                .ToListAsync();

            return result;
        }
    }
}
