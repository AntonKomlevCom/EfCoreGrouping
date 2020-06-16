using RugbyLeague.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RugbyLeague.Repositories
{
    public interface IPlayerRepository
    {
        Task<List<PlayerModel>> GetPlayersByTeamUid(Guid teamUid);
    }
}