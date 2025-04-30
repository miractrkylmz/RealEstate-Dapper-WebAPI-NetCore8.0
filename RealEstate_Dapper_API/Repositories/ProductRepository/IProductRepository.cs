using RealEstate_Dapper_API.DTOs.ProductDetailDTOs;
using RealEstate_Dapper_API.DTOs.ProductDTOs;

namespace RealEstate_Dapper_API.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<List<ResultProductDTO>> GetAllProduct();
        Task<List<ResultProductAdvertListWithCategoryByEmployeeDTO>> GetProductAdvertListByEmployeeByTrue(int id);
        Task<List<ResultProductAdvertListWithCategoryByEmployeeDTO>> GetProductAdvertListByEmployeeByFalse(int id);
        Task<List<ResultProductWithCategoryDTO>> GetAllProductWithCategory();
        Task ProductChangeDealOfTheDayStatusToTrue(int id);
        Task ProductChangeDealOfTheDayStatusToFalse(int id);
        Task<List<ResultLast5PRoductWithCategoryDTO>> GetLast5ProductList();
        Task<List<ResultLast3PRoductWithCategoryDTO>> GetLast3ProductList();
        Task CreateProduct(CreateProductDto createProductDto);
        Task<GetProductDetailByProductIdDto> GetProductDetailByProductIdDto(int id);
        Task<GetProductDetailByIdDto> GetProductDetailByIdDto(int id);
        Task<List<ResultProductWithSearchFiltersDto>> ResultProductWithSearchFilters(string searchKeyValue, int propertyCategoryId, string city);
        Task<List<ResultProductWithCategoryDTO>> GetProductByDealOfTheDayTrueWithCategory();
    }
}
