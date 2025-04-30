using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_API.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductsRepositories;

namespace RealEstate_Dapper_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstateAgentLastProductsController(ILast5ProductRepository _last5Product) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetLast5Product(int id)
        {
            var values =  await _last5Product.GetLast5ProductList(id);
            return Ok(values);
        }
    }
}
