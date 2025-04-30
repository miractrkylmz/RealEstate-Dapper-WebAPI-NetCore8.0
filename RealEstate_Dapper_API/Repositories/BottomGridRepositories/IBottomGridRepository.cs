using RealEstate_Dapper_API.DTOs.BottomGridDTOs;

namespace RealEstate_Dapper_API.Repositories.BottomGridRepositories
{
    public interface IBottomGridRepository
    {
        Task<List<ResultBottomGridDTO>> GetAllBottomGrid();
        Task CreateBottomGrid(CreateBottomGridDTO BottomGridDTO);
        Task DeleteBottomGrid(int id);
        Task UpdateBottomGrid(UpdateBottomGridDTO updateBottomGridDTO);
        Task<GetBottomGridDTO> GetByIDBottomGrid(int id);
    }
}
