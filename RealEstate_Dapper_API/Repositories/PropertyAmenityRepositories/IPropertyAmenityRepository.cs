using RealEstate_Dapper_API.DTOs.PropertyAmenityDTOs;

namespace RealEstate_Dapper_API.Repositories.PropertyAmenityRepositories
{
    public interface IPropertyAmenityRepository
    {
        Task<List<ResultPropertyAmenityByStatusTrueDto>> ResultPropertyAmenityByStatusTrue(int id);
    }
}
