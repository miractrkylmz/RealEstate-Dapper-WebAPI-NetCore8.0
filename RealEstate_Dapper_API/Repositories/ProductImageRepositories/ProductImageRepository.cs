using Dapper;
using RealEstate_Dapper_API.DTOs.ProductImageDTOs;
using RealEstate_Dapper_API.Models.DapperContext;

namespace RealEstate_Dapper_API.Repositories.ProductImageRepositories
{
    public class ProductImageRepository(Context _context) : IProductImageRepository
    {
        public async Task<List<GetProductImageByProductIdDto>> GetProductImageByProductId(int id)
        {
            string query = "select * from ProductImage where ProductId=@productid";
            using var connection = _context.CreateConnection();
            var value = await connection.QueryAsync<GetProductImageByProductIdDto>(query, new { productid = id });
            return value.ToList();
        }
    }
}
