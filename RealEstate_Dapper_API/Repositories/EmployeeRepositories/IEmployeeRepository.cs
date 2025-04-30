using RealEstate_Dapper_API.DTOs.EmployeeDTOs;

namespace RealEstate_Dapper_API.Repositories.EmployeeRepositories
{
    public interface IEmployeeRepository
    {
        Task<List<ResultEmployeeDTO>> GetAllEmployee();
        Task CreateEmployee(CreateEmployeeDTO employeeDTO);
        Task DeleteEmployee(int id);
        Task UpdateEmployee(UpdateEmployeeDTO updateEmployeeDTO);
        Task<GetByIDEmployeeDTO> GetByIDEmployee(int id);
    }
}
