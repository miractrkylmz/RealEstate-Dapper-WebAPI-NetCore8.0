using RealEstate_Dapper_API.DTOs.ContactDTOs;

namespace RealEstate_Dapper_API.Repositories.ContactRepositories
{
    public interface IContactRepository
    {
        Task<List<ResultContactDTO>> GetAllContact();
        Task CreateContact(CreateContactDTO employeeDTO);
        Task DeleteContact(int id);
        Task<GetByIDContactDTO> GetByIDContact(int id);
        Task<List<Last4ContactResultDTO>> GetLast4Contact();
    }
}
