using Dapper;
using RealEstate_Dapper_API.DTOs.ToDoListDTOs;
using RealEstate_Dapper_API.Models.DapperContext;

namespace RealEstate_Dapper_API.Repositories.ToDoListRepositories
{
    public class ToDoListRepository(Context _context) : IToDoListRepository
    {
        public Task CreateToDoList(CreateToDoListDTO employeeDTO)
        {
            throw new NotImplementedException();
        }

        public Task DeleteToDoList(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultToDoListDTO>> GetAllToDoList()
        {
            string query = "Select * from ToDoList";
            using var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultToDoListDTO>(query);
            return values.ToList();
        }

        public Task<List<GetByIDToDoListDTO>> GetByIDToDoList(int id)
        {
            throw new NotImplementedException();
        }
    }
}
