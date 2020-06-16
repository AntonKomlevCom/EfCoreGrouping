using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RugbyLeague.Models.Reports.DataByDivision;
using RugbyLeague.Repositories;

namespace RugbyLeague.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IReportRepository _reportRepository;
        public ReportController(IReportRepository reportRepository)
        {
            _reportRepository = reportRepository;
        }

        [HttpGet("GetDataByDivision/{divisionUid}")]
        public async Task<List<DataByDivisionModel>> GetDataByDivision(Guid divisionUid)
        {
            var result = await _reportRepository.GetDataByDivision(divisionUid);
            return result;
        }
    }
}
