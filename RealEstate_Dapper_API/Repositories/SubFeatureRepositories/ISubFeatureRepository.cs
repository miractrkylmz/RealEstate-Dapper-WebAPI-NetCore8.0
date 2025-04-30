using RealEstate_Dapper_API.DTOs.SubFeatureDTOs;

namespace RealEstate_Dapper_API.Repositories.SubFeatureRepositories
{
    public interface ISubFeatureRepository
    {
        Task<List<ResultSubFeatureDto>> GetAllSubFeature();
    }
}
