using Dapper;
using RealEstate_Dapper_API.DTOs.CategoryDTOs;
using RealEstate_Dapper_API.DTOs.ServiceDTOs;
using RealEstate_Dapper_API.DTOs.WhoWeAreDetailDTOs;
using RealEstate_Dapper_API.Models.DapperContext;

namespace RealEstate_Dapper_API.Repositories.ServiceRepository
{
    public class ServiceRepository(Context _context) : IServiceRepository
    {
        public async Task CreateService(CreateServiceDTO serviceDTO)
        {
            string query = "insert into Service (ServiceName,ServiceStatus) values (@service,@servicestatus)";
            using var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, new
            {
                service = serviceDTO.ServiceName,
                servicestatus = true,
            });
        }

        public async Task DeleteService(int id)
        {
            string query = "delete from Service where ServiceID=@hizmetid";
            using var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, new { hizmetid = id});
        }

        public async Task<List<ResultBottomGridDTO>> GetAllService()
        {
            string query = "Select * from Service";
            using var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultBottomGridDTO>(query);
            return values.ToList();
        }

        public async Task<GetByIDServiceDTO> GetByIDService(int id)
        {
            string query = "select * from Service where ServiceID=@id";
            using var connection = _context.CreateConnection();
            var value = await connection.QueryFirstOrDefaultAsync<GetByIDServiceDTO>(query, new { id = id });
            return value;
        }

        public async Task UpdateService(UpdateServiceDTO updateServiceDTO)
        {
            string query = "update Service set ServiceName=@servicename,ServiceStatus=@servicestatus where ServiceID=@serviceid";
            using var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, new { servicename = updateServiceDTO.ServiceName, servicestatus=updateServiceDTO.ServiceStatus,serviceid = updateServiceDTO.ServiceID});
        }
    }
}
