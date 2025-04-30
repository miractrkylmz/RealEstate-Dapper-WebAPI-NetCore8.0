using Dapper;
using RealEstate_Dapper_API.DTOs.ChartDTOs;
using RealEstate_Dapper_API.Models.DapperContext;

namespace RealEstate_Dapper_API.Repositories.EstateAgentRepositories.DashboardRepositories.ChartRepositories
{
    public class ChartRepository(Context _context) : IChartRepository
    {
        public async Task<List<ResultChartDTO>> Get5CityForChart()
        {
            string query = "Select top(5) City,Count(*) as 'CityCount' From Product Group By City order By CityCount Desc";
            using var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultChartDTO>(query);
            return values.ToList();
        }
    }
}
