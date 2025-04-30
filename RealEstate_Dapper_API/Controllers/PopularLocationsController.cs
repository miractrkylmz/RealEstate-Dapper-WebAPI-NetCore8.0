using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_API.DTOs.PopularLocationDTOs;
using RealEstate_Dapper_API.Repositories.PopularLocationRepositories;

namespace RealEstate_Dapper_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PopularLocationsController(IPopularLocationRepostiory _locationRepository) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllLocations()
        {
            var value = await _locationRepository.GetAllPopularLocation();
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePopularLocation(CreatePopularLocationDTO createPopularLocationDTO)
        {
            await _locationRepository.CreatePopularLocation(createPopularLocationDTO);
            return Ok("Popüler Lokasyonlar Verisi Başarılı Şekilde Eklendi!");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePopularLocation(int id)
        {
            await _locationRepository.DeletePopularLocation(id);
            return Ok("Popüler Lokasyonlar Verisi Başarılı Bir Şekilde Silindi!");
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePopularLocation(UpdatePopularLocationDTO updatePopularLocationDTO)
        {
            await _locationRepository.UpdatePopularLocation(updatePopularLocationDTO);
            return Ok("Popüler Lokasyonlar Verisi Başarıyla Güncellendi!");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPopularLocationByID(int id)
        {
            var value = await _locationRepository.GetByIDPopularLocation(id);
            return Ok(value);
        }
    }
}
