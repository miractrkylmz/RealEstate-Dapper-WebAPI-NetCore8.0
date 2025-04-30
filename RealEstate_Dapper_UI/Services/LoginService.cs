using System.Security.Claims;

namespace RealEstate_Dapper_UI.Services
{
    public class LoginService(IHttpContextAccessor _contextAccessor) : ILoginService
    {

        public string GetUserId => _contextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
    }
}
