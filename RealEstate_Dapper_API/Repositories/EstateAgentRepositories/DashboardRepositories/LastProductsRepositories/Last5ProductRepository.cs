using Dapper;
using RealEstate_Dapper_API.DTOs.ProductDTOs;
using RealEstate_Dapper_API.Models.DapperContext;

namespace RealEstate_Dapper_API.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductsRepositories
{
    public class Last5ProductRepository(Context _context) : ILast5ProductRepository
    {
        public async Task<List<ResultLast5PRoductWithCategoryDTO>> GetLast5ProductList(int id)
        {
            string query = "select Top(5) ID,Title,Price,City,District,ProductCategory,CategoryName,ProductDate from product inner join Category on Product.ProductCategory = Category.CategoryID where EmployeeID = @employeeid Order By ID Desc";
            using var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultLast5PRoductWithCategoryDTO>(query,new {employeeid = id});
            return values.ToList();
        }
    }
}
