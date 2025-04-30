using Dapper;
using RealEstate_Dapper_API.Models.DapperContext;

namespace RealEstate_Dapper_API.Repositories.EstateAgentRepositories.DashboardRepositories.StatisticRepositories
{
    public class StatisticRepository(Context _context) : IStatisticRepository
    {
        public int AllProductCount()
        {
            string query = "select COUNT(*) from Product";
            using var connection = _context.CreateConnection();
            var values = connection.QueryFirstOrDefault<int>(query);
            return values;
        }

        public int ProductCountByEmployeeId(int id)
        {
            string query = "select COUNT(*) from Product where EmployeeID = @employeeid";
            using var connection = _context.CreateConnection();
            var values = connection.QueryFirstOrDefault<int>(query, new {employeeid = id});
            return values;
        }

        public int ProductCountByStatusFalse(int id)
        {
            string query = "select COUNT(*) from Product where EmployeeID = @employeeid and ProductStatus = 0";
            using var connection = _context.CreateConnection();
            var values = connection.QueryFirstOrDefault<int>(query, new { employeeid = id });
            return values;
        }

        public int ProductCountByStatusTrue(int id)
        {
            string query = "select COUNT(*) from Product where EmployeeID = @employeeid and ProductStatus = 1";
            using var connection = _context.CreateConnection();
            var values = connection.QueryFirstOrDefault<int>(query, new { employeeid = id });
            return values;
        }
    }
}
