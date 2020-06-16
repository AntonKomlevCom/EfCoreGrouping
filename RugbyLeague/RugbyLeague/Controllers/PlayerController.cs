using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RugbyLeague.Models;
using RugbyLeague.Repositories;

namespace RugbyLeague.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerRepository _playerRepository;
        public PlayerController(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        [HttpGet("GetPlayers/{teamUid}")]
        public async Task<List<PlayerModel>> GetPlayers(Guid teamUid)
        {
            var players = await _playerRepository.GetPlayersByTeamUid(teamUid);
            return players;
        }
    }
}
