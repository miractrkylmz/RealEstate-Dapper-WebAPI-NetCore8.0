using Dapper;
using RealEstate_Dapper_API.DTOs.CategoryDTOs;
using RealEstate_Dapper_API.Models.DapperContext;

namespace RealEstate_Dapper_API.Repositories.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Context _context;

        public CategoryRepository(Context context)
        {
            _context = context;
        }

        public async Task CreateCategory(CreateCategoryDTO categoryDTO)
        {
            string query = "insert into Category (CategoryName,CategoryStatus) values (@categoryName,@categoryStatus)";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryName", categoryDTO.CategoryName);
            parameters.Add("@categoryStatus", true);
            using var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, parameters);
        }

        public async Task DeleteCategory(int id)
        {
            string query = "Delete from Category where CategoryID=@categoryID";
            using var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query,new{categoryID=id});
        }

        public async Task<List<ResultCategoryDTO>> GetAllCategory()
        {
            string query = "Select * from Category";
            using var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultCategoryDTO>(query);
            return values.ToList();
        }

        public async Task<GetByIDCategoryDTO> GetByIDCategory(int id)
        {
            string query = "select * from Category where CategoryID=@categoryID";
            using var connection = _context.CreateConnection();
            var value = await connection.QueryFirstOrDefaultAsync<GetByIDCategoryDTO>(query, new{categoryID=id});
            return value;
        }

        public async Task UpdateCategory(UpdateCategoryDTO updateCategoryDTO)
        {
            string query = "update Category set CategoryName=@categoryName,CategoryStatus=@categoryStatus where CategoryID=@categoryID";
            using var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, new{CategoryName=updateCategoryDTO.CategoryName,categoryID=updateCategoryDTO.CategoryID,CategoryStatus=true});
        }
    }
}
