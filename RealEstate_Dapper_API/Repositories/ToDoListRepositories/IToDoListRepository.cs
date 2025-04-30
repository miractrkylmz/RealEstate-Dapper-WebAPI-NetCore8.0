using RealEstate_Dapper_API.DTOs.ToDoListDTOs;

namespace RealEstate_Dapper_API.Repositories.ToDoListRepositories
{
    public interface IToDoListRepository
    {
        Task<List<ResultToDoListDTO>> GetAllToDoList();
        Task CreateToDoList(CreateToDoListDTO employeeDTO);
        Task DeleteToDoList(int id);
        Task<List<GetByIDToDoListDTO>> GetByIDToDoList(int id);
    }
}
