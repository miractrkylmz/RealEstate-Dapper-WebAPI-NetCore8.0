using RealEstate_Dapper_API.DTOs.CategoryDTOs;
using RealEstate_Dapper_API.DTOs.ServiceDTOs;

namespace RealEstate_Dapper_API.Repositories.ServiceRepository
{
    public interface IServiceRepository
    {
        Task<List<ResultBottomGridDTO>> GetAllService();
        Task CreateService(CreateServiceDTO serviceDTO);
        Task DeleteService(int id);
        Task UpdateService(UpdateServiceDTO updateServiceDTO);
        Task<GetByIDServiceDTO> GetByIDService(int id);
    }
}
