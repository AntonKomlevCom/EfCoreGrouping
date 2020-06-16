using RugbyLeague.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RugbyLeague.Repositories
{
    public interface ITeamRepository
    {
        Task<List<TeamModel>> GetTeamsByDivisionUid(Guid divisionUid);
    }
}