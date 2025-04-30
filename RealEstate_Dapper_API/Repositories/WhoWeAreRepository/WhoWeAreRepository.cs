using Dapper;
using RealEstate_Dapper_API.DTOs.CategoryDTOs;
using RealEstate_Dapper_API.DTOs.WhoWeAreDetailDTOs;
using RealEstate_Dapper_API.DTOs.WhoWeAreDTOs;
using RealEstate_Dapper_API.Models.DapperContext;

namespace RealEstate_Dapper_API.Repositories.WhoWeAreRepository
{
    public class WhoWeAreRepository : IWhoWeAreRepository
    {
        private readonly Context _context;

        public WhoWeAreRepository(Context context)
        {
            _context = context;
        }

        public async Task CreateWhoWeAreDetail(CreateWhoWeAreDetailDTO createWhoWeAreDetailDTO)
        {
            string query = "insert into WhoWeAreDetail (Title,Subtitle,Description1,Description2) values (@title,@subtitle,@description1,@description2)";
            using var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, new
            {
                Title = createWhoWeAreDetailDTO.Title,
                Subtitle = createWhoWeAreDetailDTO.Subtitle,
                Description1 = createWhoWeAreDetailDTO.Description1,
                Description2 = createWhoWeAreDetailDTO.Description2
            });
        }

        public async Task DeleteWhoWeAreDetail(int id)
        {
            string query = "Delete from WhoWeAreDetail where WhoWeAreDetailID=@whowearedetailid";
            using var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, new { whowearedetailid = id });
        }

        public async Task<List<ResultWhoWeAreDetailDtO>> GetAllWhoWeAreDetail()
        {
            string query = "select * from WhoWeAreDetail";
            using var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultWhoWeAreDetailDtO>(query);
            return values.ToList();
        }

        public async Task<GetByIDWhoWeAreDetailDTO> GetByIDWhoWeAreDetail(int id)
        {
            string query = "select * from WhoWeAreDetail where WhoWeAreDetailID=@deneme";
            using var connection = _context.CreateConnection();
            var value = await connection.QueryFirstOrDefaultAsync<GetByIDWhoWeAreDetailDTO>(query, new { deneme = id });
            return value;
        }

        public async Task UpdateWhoWeAreDetail(UpdateWhoWeAreDetailDTO updateWhoWeAreDetailDTO)
        {
            string query = "update WhoWeAreDetail set Title=@title,Subtitle=@subtitle,Description1=@description1,Description2=@description2 where WhoWeAreDetailID=@whowearedetailid";
            using var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, new {title = updateWhoWeAreDetailDTO.Title,subtitle = updateWhoWeAreDetailDTO.Subtitle, description1 = updateWhoWeAreDetailDTO.Description1, description2 = updateWhoWeAreDetailDTO.Description2, whowearedetailid = updateWhoWeAreDetailDTO.WhoWeAreDetailID });
        }
    }
}
