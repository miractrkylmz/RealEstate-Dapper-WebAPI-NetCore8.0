using Dapper;
using RealEstate_Dapper_API.DTOs.ContactDTOs;
using RealEstate_Dapper_API.Models.DapperContext;

namespace RealEstate_Dapper_API.Repositories.ContactRepositories
{
    public class ContactRepository(Context _context) : IContactRepository
    {
        public Task CreateContact(CreateContactDTO employeeDTO)
        {
            throw new NotImplementedException();
        }

        public Task DeleteContact(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultContactDTO>> GetAllContact()
        {
            throw new NotImplementedException();
        }

        public Task<GetByIDContactDTO> GetByIDContact(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Last4ContactResultDTO>> GetLast4Contact()
        {
            string query = "select Top(4)* from Contact order by ContactID desc";
            using var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<Last4ContactResultDTO>(query);
            return values.ToList();
        }
    }
}
