using RealEstate_Dapper_API.DTOs.CategoryDTOs;

namespace RealEstate_Dapper_API.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDTO>> GetAllCategory();
        Task CreateCategory(CreateCategoryDTO categoryDTO);
        Task DeleteCategory(int id);
        Task UpdateCategory(UpdateCategoryDTO updateCategoryDTO);
        Task<GetByIDCategoryDTO> GetByIDCategory(int id);
    }
}
