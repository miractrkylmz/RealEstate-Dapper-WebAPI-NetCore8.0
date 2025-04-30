using Dapper;
using RealEstate_Dapper_API.DTOs.AppUserDTOs;
using RealEstate_Dapper_API.Models.DapperContext;

namespace RealEstate_Dapper_API.Repositories.AppUserRepositories
{
    public class AppUserRepository(Context _context) : IAppUserRepository
    {
        public async Task<GetAppUserByProductIDDto> GetAppUserByProductId(int id)
        {
            string query = "Select * from AppUser where UserID=@userid";
            using var connection = _context.CreateConnection();
            var values = await connection.QueryFirstOrDefaultAsync<GetAppUserByProductIDDto>(query, new { userid = id });
            return values;
        }
    }
}