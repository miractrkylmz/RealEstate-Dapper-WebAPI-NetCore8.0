using Dapper;
using RealEstate_Dapper_API.DTOs.BottomGridDTOs;
using RealEstate_Dapper_API.Models.DapperContext;

namespace RealEstate_Dapper_API.Repositories.BottomGridRepositories
{
    public class BottomGridRepository : IBottomGridRepository
    {
        private readonly Context _context;

        public BottomGridRepository(Context context)
        {
            _context = context;
        }

        public async Task CreateBottomGrid(CreateBottomGridDTO BottomGridDTO)
        {
            string query = "insert into BottomGrid (Icon,Title,Description) values (@icon,@title,@description)";
            using var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, new
            {
                icon = BottomGridDTO.Icon,
                title = BottomGridDTO.Title,
                description = BottomGridDTO.Description,
            });
        }

        public async Task DeleteBottomGrid(int id)
        {
            string query = "delete from BottomGrid where BottomGridID=@bottomgridid";
            using var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, new { bottomgridid = id });
        }

        public async Task<List<ResultBottomGridDTO>> GetAllBottomGrid()
        {
            string query = "select * from BottomGrid";
            using var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultBottomGridDTO>(query);
            return values.ToList();
        }

        public async Task<GetBottomGridDTO> GetByIDBottomGrid(int id)
        {
            string query = "select * from BottomGrid where BottomGridID=@bottomgridid";
            using var connection = _context.CreateConnection();
            var value = await connection.QueryFirstOrDefaultAsync<GetBottomGridDTO>(query, new { bottomgridid = id });
            return value;
        }

        public async Task UpdateBottomGrid(UpdateBottomGridDTO updateBottomGridDTO)
        {
            string query = "update BottomGrid set Icon=@icon,Title=@title,Description=@description where BottomGridID=@bottomgridid";
            using var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, new { icon=updateBottomGridDTO.Icon,title = updateBottomGridDTO.Title,description = updateBottomGridDTO.Description,bottomgridid=updateBottomGridDTO.BottomGridID });
        }
    }
}
