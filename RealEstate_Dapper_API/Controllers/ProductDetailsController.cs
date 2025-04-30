using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_API.Models.DapperContext;
using RealEstate_Dapper_API.Repositories.ProductRepository;

namespace RealEstate_Dapper_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDetailsController(IProductRepository _productRepository) : ControllerBase
    {
        [HttpGet("GetProductDetailByIdDto")]
        public async Task<IActionResult> GetProductDetailByIdDto(int id)
        {
            var value = await _productRepository.GetProductDetailByIdDto(id);
            return Ok(value);
        }
    }
}
