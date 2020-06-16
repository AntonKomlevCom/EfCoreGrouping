using RugbyLeague.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RugbyLeague.Repositories
{
    public interface IDivisionRepository
    {
        Task<List<DivisionModel>> GetDivisionByUid(Guid divisionUid);
    }
}