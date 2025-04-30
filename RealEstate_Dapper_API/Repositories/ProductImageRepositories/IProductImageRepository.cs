using RealEstate_Dapper_API.DTOs.ProductImageDTOs;

namespace RealEstate_Dapper_API.Repositories.ProductImageRepositories
{
    public interface IProductImageRepository
    {
        Task<List<GetProductImageByProductIdDto>> GetProductImageByProductId(int id);
    }
}
