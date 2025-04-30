using Dapper;
using RealEstate_Dapper_API.DTOs.TestimonialDTOs;
using RealEstate_Dapper_API.Models.DapperContext;

namespace RealEstate_Dapper_API.Repositories.TestimonialRepository
{
    public class TestimonialRepository : ITestimonialRepository
    {
        private readonly Context _context;

        public TestimonialRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultTestimonialDTO>> GetAllTestimonial()
        {
            string query = "Select * from Testimonial";
            using var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultTestimonialDTO>(query);
            return values.ToList();
        }
    }
}
