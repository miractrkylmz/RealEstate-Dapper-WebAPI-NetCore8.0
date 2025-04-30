using RealEstate_Dapper_API.DTOs.ProductDTOs;

namespace RealEstate_Dapper_API.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductsRepositories
{
    public interface ILast5ProductRepository
    {
        Task<List<ResultLast5PRoductWithCategoryDTO>> GetLast5ProductList(int id);
    }
}
