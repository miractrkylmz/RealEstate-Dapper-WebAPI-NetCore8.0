using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_API.Repositories.SubFeatureRepositories;

namespace RealEstate_Dapper_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubFeaturesController(ISubFeatureRepository _subFeatures) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllSubFeature()
        {
            var values = await _subFeatures.GetAllSubFeature();
            return Ok(values);
        }
    }
}
