using RealEstate_Dapper_API.DTOs.CategoryDTOs;
using RealEstate_Dapper_API.DTOs.WhoWeAreDetailDTOs;
using RealEstate_Dapper_API.DTOs.WhoWeAreDTOs;

namespace RealEstate_Dapper_API.Repositories.WhoWeAreRepository
{
    public interface IWhoWeAreRepository
    {
        Task<List<ResultWhoWeAreDetailDtO>> GetAllWhoWeAreDetail();
        Task CreateWhoWeAreDetail(CreateWhoWeAreDetailDTO createWhoWeAreDetailDTO);
        Task DeleteWhoWeAreDetail(int id);
        Task UpdateWhoWeAreDetail(UpdateWhoWeAreDetailDTO updateWhoWeAreDetailDTO);
        Task<GetByIDWhoWeAreDetailDTO> GetByIDWhoWeAreDetail(int id);
    }
}
