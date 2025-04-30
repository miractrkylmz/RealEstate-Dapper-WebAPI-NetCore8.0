using Dapper;
using RealEstate_Dapper_API.DTOs.PopularLocationDTOs;
using RealEstate_Dapper_API.DTOs.ServiceDTOs;
using RealEstate_Dapper_API.Models.DapperContext;

namespace RealEstate_Dapper_API.Repositories.PopularLocationRepositories
{
    public class PopularLocationRepository : IPopularLocationRepostiory
    {
        private readonly Context _context;
        public PopularLocationRepository(Context context)
        {
            _context = context;
        }

        public async Task CreatePopularLocation(CreatePopularLocationDTO popularLocationDTO)
        {
            string query = "insert into PopularLocations (CityName,ImageURL) values (@cityName,@imageURL)";
            using var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, new
            {
                cityName = popularLocationDTO.CityName,
                imageURL = popularLocationDTO.ImageURL,
            });
        }

        public async Task DeletePopularLocation(int id)
        {
            string query = "delete from PopularLocations where LocationID=@locationID";
            using var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, new { locationID = id });
        }

        public async Task<List<ResultPopularLocationDTO>> GetAllPopularLocation()
        {
            string query = "Select * from PopularLocations";
            using var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultPopularLocationDTO>(query);
            return values.ToList();
        }

        public async Task<GetByIDPopularLocationDTO> GetByIDPopularLocation(int id)
        {
            string query = "select * from PopularLocations where LocationID=@locationID";
            using var connection = _context.CreateConnection();
            var value = await connection.QueryFirstOrDefaultAsync<GetByIDPopularLocationDTO>(query, new { locationID = id });
            return value;
        }

        public async Task UpdatePopularLocation(UpdatePopularLocationDTO updatePopularLocationDTO)
        {
            string query = "update PopularLocations set CityName=@cityName,ImageURL=@imageURL where LocationID=@locationID";
            using var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, new { cityName = updatePopularLocationDTO.CityName, imageURL = updatePopularLocationDTO.ImageURL, locationID = updatePopularLocationDTO.LocationID });
        }
    }
}
