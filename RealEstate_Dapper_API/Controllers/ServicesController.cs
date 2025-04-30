using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_API.DTOs.ServiceDTOs;
using RealEstate_Dapper_API.Repositories.ServiceRepository;

namespace RealEstate_Dapper_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController(IServiceRepository _serviceRepository) : ControllerBase
    {                                     
        [HttpGet]
        public async Task<IActionResult> GetServiceList()
        {
            var value = await _serviceRepository.GetAllService();
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateService(CreateServiceDTO createServiceDTO)
        {
            await _serviceRepository.CreateService(createServiceDTO);
            return Ok("Hizmet Kısmı Başarılı Şekilde Eklendi!");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteService(int id)
        {
            await _serviceRepository.DeleteService(id);
            return Ok("Hizmet Kısmı Başarılı Bir Şekilde Silindi!");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateService(UpdateServiceDTO updateServiceDTO)
        {
            await _serviceRepository.UpdateService(updateServiceDTO);
            return Ok("Hizmet Kısmı Başarıyla Güncellendi!");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetServiceByID(int id)
        {
            var value = await _serviceRepository.GetByIDService(id);
            return Ok(value);
        }
    }
}
