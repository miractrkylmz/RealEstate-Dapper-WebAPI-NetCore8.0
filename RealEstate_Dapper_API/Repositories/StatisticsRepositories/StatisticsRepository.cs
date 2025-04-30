using Dapper;
using RealEstate_Dapper_API.DTOs.CategoryDTOs;
using RealEstate_Dapper_API.Models.DapperContext;

namespace RealEstate_Dapper_API.Repositories.StatisticsRepositories
{
    public class StatisticsRepository(Context _context) : IStatisticsRepository
    {
        public int ActiveCategoryCount()
        {
            string query = "Select Count(*) from Category where CategoryStatus=1";
            using var connection = _context.CreateConnection();
            var values = connection.QueryFirstOrDefault<int>(query);
            return values;
        }

        public int ActiveEmployeeCount()
        {
            string query = "Select Count(*) from Employee where Status=1";
            using var connection = _context.CreateConnection();
            var values = connection.QueryFirstOrDefault<int>(query);
            return values;
        }

        public int ApartmantCount()
        {
            string query = "Select count(*) from product where Title Like '%Daire%'";
            using var connection = _context.CreateConnection();
            var values = connection.QueryFirstOrDefault<int>(query);
            return values;
        }

        public decimal AvgProductPriceByRent()
        {
            string query = "Select avg(Price) from product where Type = 'Kiralık'";
            using var connection = _context.CreateConnection();
            var values = connection.QueryFirstOrDefault<decimal>(query);
            return values;
        }

        public decimal AvgProductPriceBySale()
        {
            string query = "Select avg(Price) from product where Type = 'Satılık'";
            using var connection = _context.CreateConnection();
            var values = connection.QueryFirstOrDefault<decimal>(query);
            return values;
        }

        public int AvgRoomCount()
        {
            string query = "Select avg(RoomCount) from productdetails";
            using var connection = _context.CreateConnection();
            var values = connection.QueryFirstOrDefault<int>(query);
            return values;
        }

        public int CategoryCount()
        {
            string query = "Select count(*) from category";
            using var connection = _context.CreateConnection();
            var values = connection.QueryFirstOrDefault<int>(query);
            return values;
        }

        public string CategoryNameByMaxProductCount()
        {
            string query = "Select top(1) CategoryName, COUNT(*) from Product inner join Category on Product.ProductCategory=Category.CategoryID Group By CategoryName order by COUNT(*)";
            using var connection = _context.CreateConnection();
            var values = connection.QueryFirstOrDefault<string>(query);
            return values;
        }

        public string CityNameByMaxProductCount()
        {
            string query = "select Top(1) City,COUNT(*) as 'İlan_Sayısı' from Product group by City order by İlan_Sayısı desc";
            using var connection = _context.CreateConnection();
            var values = connection.QueryFirstOrDefault<string>(query);
            return values;
        }

        public int DifferentCities()
        {
            string query = "select Count(Distinct(City)) from product";
            using var connection = _context.CreateConnection();
            var values = connection.QueryFirstOrDefault<int>(query);
            return values;
        }

        public string EmployeeNameByMaxProductCount()
        {
            string query = "select EmployeeName,COUNT(*) 'product_count' from Product inner join Employee on Product.EmployeeID=Employee.EmployeeID group by EmployeeName order by product_count desc";
            using var connection = _context.CreateConnection();
            var values = connection.QueryFirstOrDefault<string>(query);
            return values;
        }

        public decimal LastProductPrice()
        {
            string query = "select Top(1)Price from product  order by ID desc";
            using var connection = _context.CreateConnection();
            var values = connection.QueryFirstOrDefault<decimal>(query);
            return values;
        }

        public string NewestBuildingYear()
        {
            string query = "select Top(1)BuildYear from ProductDetails Order By BuildYear desc";
            using var connection = _context.CreateConnection();
            var values = connection.QueryFirstOrDefault<string>(query);
            return values;
        }

        public string OldestBuildingYear()
        {
            string query = "select Top(1)BuildYear from ProductDetails Order By BuildYear asc";
            using var connection = _context.CreateConnection();
            var values = connection.QueryFirstOrDefault<string>(query);
            return values;
        }

        public int PassiveCategoryCount()
        {
            string query = "select Count(CategoryStatus) from Category where CategoryStatus=0";
            using var connection = _context.CreateConnection();
            var values = connection.QueryFirstOrDefault<int>(query);
            return values;
        }

        public int ProductCount()
        {
            string query = "select COUNT(*) from Product";
            using var connection = _context.CreateConnection();
            var values = connection.QueryFirstOrDefault<int>(query);
            return values;
        }
    }
}
