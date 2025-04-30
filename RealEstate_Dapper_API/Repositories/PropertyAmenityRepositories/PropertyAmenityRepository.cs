using Dapper;
using RealEstate_Dapper_API.DTOs.PropertyAmenityDTOs;
using RealEstate_Dapper_API.Models.DapperContext;

namespace RealEstate_Dapper_API.Repositories.PropertyAmenityRepositories
{
    public class PropertyAmenityRepository(Context _context) : IPropertyAmenityRepository
    {
        public async Task<List<ResultPropertyAmenityByStatusTrueDto>> ResultPropertyAmenityByStatusTrue(int id)
        {
            string query = "select PropertyAmenityID,Title from PropertyAmenity inner join Amenity on Amenity.AmenityID=PropertyAmenity.AmenityID where PropertyID=@propertyid and Status=1";
            using var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultPropertyAmenityByStatusTrueDto>(query, new {propertyid = id});
            return values.ToList();
        }
    }
}
