using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using RugbyLeague.Data.EfStructures;
using RugbyLeague.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RugbyLeague.Repositories
{
    public class DivisionRepository : IDivisionRepository
    {
        private readonly RugbyLeagueDbContext _dbContext;
        private readonly IMapper _mapper;

        public DivisionRepository(RugbyLeagueDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<DivisionModel>> GetDivisionByUid(Guid divisionUid)
        {
            var result = await _dbContext.Division
                .Where(d => d.Uid == divisionUid)
                .ProjectTo<DivisionModel>(_mapper.ConfigurationProvider)
                .ToListAsync();

            return result;
        }
    }
}
