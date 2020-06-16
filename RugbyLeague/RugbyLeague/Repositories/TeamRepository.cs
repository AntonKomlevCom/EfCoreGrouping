using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RugbyLeague.Data.EfStructures;
using RugbyLeague.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RugbyLeague.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly RugbyLeagueDbContext _dbContext;
        private readonly IMapper _mapper;

        public TeamRepository(RugbyLeagueDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<TeamModel>> GetTeamsByDivisionUid(Guid divisionUid)
        {
            var query = _dbContext.Team
                .Include(t => t.Division)
                .Where(t => t.Division.Uid == divisionUid);

            var result = await query.Select(t => _mapper.Map<TeamModel>(t)).ToListAsync();
            return result;
        }

    }
}
