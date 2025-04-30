using Dapper;
using RealEstate_Dapper_API.DTOs.CategoryDTOs;
using RealEstate_Dapper_API.DTOs.EmployeeDTOs;
using RealEstate_Dapper_API.Models.DapperContext;

namespace RealEstate_Dapper_API.Repositories.EmployeeRepositories
{
    public class EmployeeRepository(Context _context) : IEmployeeRepository
    {
        public async Task CreateEmployee(CreateEmployeeDTO employeeDTO)
        {
            string query = "insert into Employee (EmployeeName,Title,Mail,PhoneNumber,ImageURL,Status) values (@name,@title,@mail,@number,@image,@status)";
            using var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, new {name=employeeDTO.EmployeeName,title=employeeDTO.Title,mail=employeeDTO.Mail,number=employeeDTO.PhoneNumber,image=employeeDTO.ImageURL,status=true});
        }

        public async Task DeleteEmployee(int id)
        {
            string query = "Delete from Employee where EmployeeID=@id";
            using var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, new { id = id });
        }

        public async Task<List<ResultEmployeeDTO>> GetAllEmployee()
        {
            string query = "Select * from Employee";
            using var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultEmployeeDTO>(query);
            return values.ToList();
        }

        public async Task<GetByIDEmployeeDTO> GetByIDEmployee(int id)
        {
            string query = "select * from Employee where EmployeeID=@employeeID";
            using var connection = _context.CreateConnection();
            var value = await connection.QueryFirstOrDefaultAsync<GetByIDEmployeeDTO>(query, new { employeeID = id });
            return value;
        }

        public async Task UpdateEmployee(UpdateEmployeeDTO updateEmployeeDTO)
        {
            string query = "update Employee set EmployeeName=name ,Title=title,Mail=mail,PhoneNumber=number,ImageURL=image,Status=status";
            using var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, new { name = updateEmployeeDTO.EmployeeName, title = updateEmployeeDTO.Title, mail = updateEmployeeDTO.Mail, number = updateEmployeeDTO.PhoneNumber, image = updateEmployeeDTO.ImageURL, status = true });
        }
    }
}
