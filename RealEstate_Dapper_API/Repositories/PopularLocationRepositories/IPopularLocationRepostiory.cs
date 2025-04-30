using RealEstate_Dapper_API.DTOs.BottomGridDTOs;
using RealEstate_Dapper_API.DTOs.PopularLocationDTOs;

namespace RealEstate_Dapper_API.Repositories.PopularLocationRepositories
{
    public interface IPopularLocationRepostiory
    {
        Task<List<ResultPopularLocationDTO>> GetAllPopularLocation();
        Task CreatePopularLocation(CreatePopularLocationDTO popularLocationDTO);
        Task DeletePopularLocation(int id);
        Task UpdatePopularLocation(UpdatePopularLocationDTO updatePopularLocationDTO);
        Task<GetByIDPopularLocationDTO> GetByIDPopularLocation(int id);
    }
}
