using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_API.DTOs.LoginDTOs;
using RealEstate_Dapper_API.Models.DapperContext;
using RealEstate_Dapper_API.Tools;

namespace RealEstate_Dapper_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController(Context _context) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> SignIn(CreateLoginDTO model)
        {
            string query = "Select * from AppUser where Username = @username and Password = @password";
            string query2 = "Select UserId from AppUser where Username = @username and Password = @password";
            using var connection = _context.CreateConnection();
            var values = await connection.QueryFirstOrDefaultAsync<CreateLoginDTO>(query, new {username = model.Username,password=model.Password});
            var values2 = await connection.QueryFirstAsync<GetAppUserIdDTO>(query2, new {username = model.Username,password=model.Password});
            if (values != null)
            {
                GetCheckAppUserDTO checkuserModel = new();
                checkuserModel.Username = model.Username;
                checkuserModel.ID = values2.UserID;
                var token = JwtTokenGenerator.GenerateToken(checkuserModel);
                return Ok(token);
            }
            else
            {
                return Ok("Başarısız");
            }
        }
    }
}
