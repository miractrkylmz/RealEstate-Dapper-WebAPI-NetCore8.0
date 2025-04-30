using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_API.DTOs.BottomGridDTOs;
using RealEstate_Dapper_API.Repositories.BottomGridRepositories;

namespace RealEstate_Dapper_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BottomGridsController(IBottomGridRepository _bottomGridRepository) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetBottomGrid()
        {
            var values = await _bottomGridRepository.GetAllBottomGrid();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBottomGrid(CreateBottomGridDTO createBottomGridDTO)
        {
            await _bottomGridRepository.CreateBottomGrid(createBottomGridDTO);
            return Ok("Veri Kısmı Başarılı Şekilde Eklendi!");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBottomGrid(int id)
        {
            await _bottomGridRepository.DeleteBottomGrid(id);
            return Ok("Veri Kısmı Başarılı Bir Şekilde Silindi!");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBottomGrid(UpdateBottomGridDTO updateBottomGridDTO)
        {
            await _bottomGridRepository.UpdateBottomGrid(updateBottomGridDTO);
            return Ok("Veri Kısmı Başarıyla Güncellendi!");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBottomGridByID(int id)
        {
            var value = await _bottomGridRepository.GetByIDBottomGrid(id);
            return Ok(value);
        }
    }
}
