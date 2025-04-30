using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_API.Repositories.EstateAgentRepositories.DashboardRepositories.ChartRepositories;

namespace RealEstate_Dapper_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstateAgentChartController(IChartRepository _chartRepository) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get5CityForChart()
        {
            var values = await _chartRepository.Get5CityForChart();
            return Ok(values);
        }
    }
}
