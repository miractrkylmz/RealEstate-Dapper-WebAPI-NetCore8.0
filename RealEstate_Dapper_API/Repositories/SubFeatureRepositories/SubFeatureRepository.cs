using Dapper;
using RealEstate_Dapper_API.DTOs.SubFeatureDTOs;
using RealEstate_Dapper_API.Models.DapperContext;

namespace RealEstate_Dapper_API.Repositories.SubFeatureRepositories
{
    public class SubFeatureRepository(Context _context) : ISubFeatureRepository
    {
        public async Task<List<ResultSubFeatureDto>> GetAllSubFeature()
        {
            string query = "Select * from SubFeature";
            using var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultSubFeatureDto>(query);
            return values.ToList();
        }
    }
}
