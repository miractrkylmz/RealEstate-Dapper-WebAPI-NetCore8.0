using Dapper;
using RealEstate_Dapper_API.DTOs.ProductDetailDTOs;
using RealEstate_Dapper_API.DTOs.ProductDTOs;
using RealEstate_Dapper_API.Models.DapperContext;

namespace RealEstate_Dapper_API.Repositories.ProductRepository
{
    public class ProductRepository(Context _context) : IProductRepository
    {
        public async Task CreateProduct(CreateProductDto model)
        {
            string query = "insert into Product (title,price,city,district,coverImage,adress,description,type,dealoftheday,productdate,productstatus,employeeID,productCategory) values (@title,@price,@city,@district,@coverImage,@adress,@description,@type,@dealoftheday,@productdate,@productstatus,@employeeID,@productCategory)";
            using var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, new {title=model.Title,price=model.Price,city=model.City,district=model.District,coverImage=model.coverImage,adress=model.adress,description=model.description,type=model.type,dealoftheday=model.dealoftheday,productdate=model.productdate,productstatus=model.productstatus,employeeID=model.employeeID,productCategory=model.productCategory});
        }

        public async Task<List<ResultProductDTO>> GetAllProduct()
        {
            string query = "select * from Product";
            using var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultProductDTO>(query);
            return values.ToList();
        }

        public async Task<List<ResultProductWithCategoryDTO>> GetAllProductWithCategory()
        {
            string query = "select ID,Title,Price,City,District,CoverImage,Adress,SlugUrl,Type,CategoryName,DealOfTheDay from product inner join Category on Product.ProductCategory=Category.CategoryID";
            using var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultProductWithCategoryDTO>(query);
            return values.ToList();
        }

        public async Task<List<ResultLast3PRoductWithCategoryDTO>> GetLast3ProductList()
        {
            string query = "select Top(3) ID,Title,Price,CoverImage,City,District,Description,ProductCategory,CategoryName,ProductDate from product inner join Category on Product.ProductCategory = Category.CategoryID Order By ID Desc";
            using var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultLast3PRoductWithCategoryDTO>(query);
            return values.ToList();
        }

        public async Task<List<ResultLast5PRoductWithCategoryDTO>> GetLast5ProductList()
        {
            string query = "select Top(5) ID,Title,Price,City,District,ProductCategory,CategoryName,ProductDate from product inner join Category on Product.ProductCategory = Category.CategoryID where Type='Kiralık' Order By ID Desc";
            using var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultLast5PRoductWithCategoryDTO>(query);
            return values.ToList();
        }

        public async Task<List<ResultProductAdvertListWithCategoryByEmployeeDTO>> GetProductAdvertListByEmployeeByFalse(int id)
        {
            string query = "select ID,Title,Price,City,District,CoverImage,Adress,Type,CategoryName,DealOfTheDay from product inner join Category on Product.ProductCategory=Category.CategoryID where EmployeeID = @employeeID and ProductStatus=0";
            using var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultProductAdvertListWithCategoryByEmployeeDTO>(query, new { employeeID = id });
            return values.ToList();
        }

        public async Task<List<ResultProductAdvertListWithCategoryByEmployeeDTO>> GetProductAdvertListByEmployeeByTrue(int id)
        {
            string query = "select ID,Title,Price,City,District,CoverImage,Adress,Type,CategoryName,DealOfTheDay from product inner join Category on Product.ProductCategory=Category.CategoryID where EmployeeID = @employeeID and ProductStatus=1";
            using var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultProductAdvertListWithCategoryByEmployeeDTO>(query,new {employeeID=id});
            return values.ToList();
        }

        public async Task<List<ResultProductWithCategoryDTO>> GetProductByDealOfTheDayTrueWithCategory()
        {
            string query = "select ID,Title,Price,City,District,CoverImage,Adress,Type,CategoryName,DealOfTheDay from product inner join Category on Product.ProductCategory=Category.CategoryID where DealOfTheDay=1";
            using var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultProductWithCategoryDTO>(query);
            return values.ToList();
        }

        public async Task<GetProductDetailByIdDto> GetProductDetailByIdDto(int id)
        {
            string query = "select * from ProductDetails where ProductID = @productid";
            using var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<GetProductDetailByIdDto>(query, new { productid = id });
            return values.FirstOrDefault();
        }

        public async Task<GetProductDetailByProductIdDto> GetProductDetailByProductIdDto(int id)
        {
            string query = "select ID,Title,Price,City,District,CoverImage,Description,Adress,SlugUrl,Type,CategoryName,DealOfTheDay,ProductDate from product inner join Category on Product.ProductCategory=Category.CategoryID where ID=@productid";
            using var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<GetProductDetailByProductIdDto>(query, new { productid=id });
            return values.FirstOrDefault();
        }

        public async Task ProductChangeDealOfTheDayStatusToFalse(int id)
        {
            string query = "update Product set DealOfTheDay=0 where ID=@productID";
            using var connection = _context.CreateConnection();
            var values  = await connection.ExecuteAsync(query, new {productID = id});
        }

        public async Task ProductChangeDealOfTheDayStatusToTrue(int id)
        {
            string query = "update Product set DealOfTheDay=1 where ID=@productID";
            using var connection = _context.CreateConnection();
            var values = await connection.ExecuteAsync(query, new { productID = id });
        }

        public async Task<List<ResultProductWithSearchFiltersDto>> ResultProductWithSearchFilters(string searchKeyValue, int propertyCategoryId, string city)
        {
            string query = "select * from Product where Title like @title and ProductCategory = @categoryID and City = @cityName";
            using var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultProductWithSearchFiltersDto>(query, new 
            { 
                title = $"%{searchKeyValue}%", 
                categoryID = propertyCategoryId, 
                cityName = city
            });
            return values.ToList();
        }
    }
}
