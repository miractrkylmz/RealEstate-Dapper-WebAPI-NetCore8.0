using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_API.DTOs.CategoryDTOs;
using RealEstate_Dapper_API.DTOs.WhoWeAreDetailDTOs;
using RealEstate_Dapper_API.Repositories.CategoryRepository;
using RealEstate_Dapper_API.Repositories.WhoWeAreRepository;

namespace RealEstate_Dapper_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhoWeAreDetailController : ControllerBase
    {
        private readonly IWhoWeAreRepository _whoweareRepository;

        public WhoWeAreDetailController(IWhoWeAreRepository whoweareRepository)
        {
            _whoweareRepository = whoweareRepository;
        }

        [HttpGet]
        public async Task<IActionResult> WhoWeAreDetailList()
        {
            var values = await _whoweareRepository.GetAllWhoWeAreDetail();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateWhoWeAreDetail(CreateWhoWeAreDetailDTO createWhoWeAreDetailDTO)
        {
            await _whoweareRepository.CreateWhoWeAreDetail(createWhoWeAreDetailDTO);
            return Ok("Hakkımızda Kısmı Başarılı Şekilde Eklendi!");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWhoWeAreDetail(int id)
        {
            await _whoweareRepository.DeleteWhoWeAreDetail(id);
            return Ok("Hakkımızda Kısmı Başarılı Bir Şekilde Silindi!");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateWhoWeAreDetail(UpdateWhoWeAreDetailDTO updateWhoWeAreDetailDTO)
        {
            await _whoweareRepository.UpdateWhoWeAreDetail(updateWhoWeAreDetailDTO);
            return Ok("Hakkımızda Kısmı Başarıyla Güncellendi!");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetWhoWeAreDetailByID(int id)
        {
            var value = await _whoweareRepository.GetByIDWhoWeAreDetail(id);
            return Ok(value);
        }
    }
}
