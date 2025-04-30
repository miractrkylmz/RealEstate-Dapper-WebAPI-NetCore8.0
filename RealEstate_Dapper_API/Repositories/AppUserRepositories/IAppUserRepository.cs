using RealEstate_Dapper_API.DTOs.AppUserDTOs;

namespace RealEstate_Dapper_API.Repositories.AppUserRepositories
{
    public interface IAppUserRepository
    {
        Task<GetAppUserByProductIDDto> GetAppUserByProductId(int id);
    }
}
