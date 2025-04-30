using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_API.DTOs.ProductDTOs;
using RealEstate_Dapper_API.Repositories.ProductRepository;

namespace RealEstate_Dapper_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController(IProductRepository _productRepository) : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> ProductList()
        {
            var values = await _productRepository.GetAllProduct();
            return Ok(values);
        }

        [HttpGet("ProductListWithCategory")]
        public async Task<IActionResult> ProductListWithCategory()
        {
            var values = await _productRepository.GetAllProductWithCategory();
            return Ok(values);
        }

        [HttpGet("ProductChangeDealOfTheDayStatusToFalse/{id}")]
        public async Task<IActionResult> ProductChangeDealOfTheDayStatusToFalse(int id)
        {
            await _productRepository.ProductChangeDealOfTheDayStatusToFalse(id);
            return Ok("İlan Günün Fırsatları Listesinden Çıkarıldı!");
        }

        [HttpGet("ProductChangeDealOfTheDayStatusToTrue/{id}")]
        public async Task<IActionResult> ProductChangeDealOfTheDayStatusToTrue(int id)
        {
            await _productRepository.ProductChangeDealOfTheDayStatusToTrue(id);
            return Ok("İlan Günün Fırsatları Listesine Eklendi!");
        }

        [HttpGet("Last5ProductList")]
        public async Task<IActionResult> Last5ProductList()
        {
            var values = await _productRepository.GetLast5ProductList();
            return Ok(values);
        }

        [HttpGet("ProductAdvertsListByEmployeeIdByTrue/{id}")]
        public async Task<IActionResult> ProductAdvertsListByEmployeeByTrue(int id)
        {
            var values = await _productRepository.GetProductAdvertListByEmployeeByTrue(id);
            return Ok(values);
        }

        [HttpGet("ProductAdvertsListByEmployeeIdByFalse/{id}")]
        public async Task<IActionResult> ProductAdvertsListByEmployeeByFalse(int id)
        {
            var values = await _productRepository.GetProductAdvertListByEmployeeByFalse(id);
            return Ok(values);
        }
        [HttpPost("CreateProduct")]
        public async Task<IActionResult> CreateProduct(CreateProductDto model)
        {
            await _productRepository.CreateProduct(model);
            return Ok("İlan başarıyla eklendi");
        }

        [HttpGet("GetProductDetailByProductIdDto")]
        public async Task<IActionResult> GetProductDetailByProductIdDto(int id)
        {
            var value = await _productRepository.GetProductDetailByProductIdDto(id);
            return Ok(value);
        }
        [HttpGet("ResultProductWithSearchFilters")]
        public async Task<IActionResult> ResultProductWithSearchFilters(string searchKeyValue, int propertyCategoryId, string city)
        {
            var values = await _productRepository.ResultProductWithSearchFilters(searchKeyValue,propertyCategoryId,city);
            return Ok(values);
        }

        [HttpGet("GetProductByDealOfTheDayTrueWithCategory")]
        public async Task<IActionResult> GetProductByDealOfTheDayTrueWithCategory()
        {
            var values = await _productRepository.GetProductByDealOfTheDayTrueWithCategory();
            return Ok(values);
        }

        [HttpGet("GetLast3ProductListAsync")]
        public async Task<IActionResult> GetLast3ProductListAsync()
        {
            var values = await _productRepository.GetLast3ProductList();
            return Ok(values);
        }
    }
}
