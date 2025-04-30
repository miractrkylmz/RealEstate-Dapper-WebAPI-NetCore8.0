using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_API.Repositories.TestimonialRepository;

namespace RealEstate_Dapper_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialRepository _estimonialRepository;

        public TestimonialController(ITestimonialRepository estimonialRepository)
        {
            _estimonialRepository = estimonialRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTestimonials()
        {
            var values = await _estimonialRepository.GetAllTestimonial();
            return Ok(values);
        }
    }
}
