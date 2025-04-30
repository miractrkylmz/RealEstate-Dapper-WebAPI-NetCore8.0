using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_API.Repositories.ProductImageRepositories;

namespace RealEstate_Dapper_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImageController(IProductImageRepository _productImages) : ControllerBase
    {
        [HttpGet("GetProductImages")]
        public async Task<IActionResult> GetProductImages(int id)
        {
            var value = await _productImages.GetProductImageByProductId(id);
            return Ok(value);
        }
    }
}
