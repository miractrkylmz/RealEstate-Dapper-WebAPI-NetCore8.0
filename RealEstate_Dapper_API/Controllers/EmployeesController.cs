using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_API.DTOs.EmployeeDTOs;
using RealEstate_Dapper_API.Repositories.EmployeeRepositories;

namespace RealEstate_Dapper_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController(IEmployeeRepository _employeeRepository) : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> EmployeeList()
        {
            var values = await _employeeRepository.GetAllEmployee();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployee(CreateEmployeeDTO createEmployeeDTO)
        {
            await _employeeRepository.CreateEmployee(createEmployeeDTO);
            return Ok("Personel Başarılı Şekilde Eklendi!");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            await _employeeRepository.DeleteEmployee(id);
            return Ok("Personel Başarılı Bir Şekilde Silindi!");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(UpdateEmployeeDTO updateEmployeeDTO)
        {
            await _employeeRepository.UpdateEmployee(updateEmployeeDTO);
            return Ok("Personel Başarıyla Güncellendi!");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployeeByID(int id)
        {
            var value = await _employeeRepository.GetByIDEmployee(id);
            return Ok(value);
        }

    }
}
