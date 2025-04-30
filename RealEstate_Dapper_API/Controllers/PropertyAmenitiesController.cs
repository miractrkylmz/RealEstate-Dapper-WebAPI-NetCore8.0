using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_API.Repositories.PropertyAmenityRepositories;

namespace RealEstate_Dapper_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyAmenitiesController(IPropertyAmenityRepository _propertyAmenity) : ControllerBase
    {
        [HttpGet("ResultPropertyAmenityByStatusTrue")]
        public async Task<IActionResult> ResultPropertyAmenityByStatusTrue(int id)
        {
            var values = await _propertyAmenity.ResultPropertyAmenityByStatusTrue(id);
            return Ok(values);
        }
    }
}
