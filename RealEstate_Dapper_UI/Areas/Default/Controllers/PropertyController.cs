using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using Newtonsoft.Json;
using NuGet.Configuration;
using RealEstate_Dapper_UI.DTOs.ProductDetailDTOs;
using RealEstate_Dapper_UI.DTOs.ProductDTOs;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace RealEstate_Dapper_UI.Areas.Default.Controllers
{
    [Area("Default")]
    public class PropertyController(IHttpClientFactory _httpClientFactory) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient("MyApiClient");
            var responseMessage = await client.GetAsync("Products/ProductListWithCategory");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductDTO>>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpGet("/Default/Property/{slug}/{id}")]
        public async Task<IActionResult> PropertySingle(int id,string slug)
        {
            ViewBag.i = id;
            var client = _httpClientFactory.CreateClient("MyApiClient");
            var responseMessage = await client.GetAsync("Products/GetProductDetailByProductIdDto?id="+id);
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<ResultProductDTO>(jsonData);
            ViewBag.title1 = values.title;
            ViewBag.price = "₺" + values.price.ToString("N0");
            ViewBag.city = values.city;
            ViewBag.district = values.district;
            ViewBag.adress = values.adress;
            ViewBag.type = values.type;
            ViewBag.desc = values.description;
            ViewBag.productid = values.id;
            ViewBag.slugUrl = values.SlugUrl;
            var dateDiff = (DateTime.Now - values.ProductDate).Days;

            if (dateDiff == 0)
            {
                ViewBag.datediff = "Bugün eklendi";
            }
            else if (dateDiff < 30)
            {
                ViewBag.datediff = $"{dateDiff} gün önce eklendi";
            }
            else
            {
                int monthDiff = dateDiff / 30;
                ViewBag.datediff = $"{monthDiff} ay önce eklendi";
            }

            var responseMessage2 = await client.GetAsync("ProductDetails/GetProductDetailByIdDto?id=" + id);
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            var values2 = JsonConvert.DeserializeObject<GetProductDetailByIdDto>(jsonData2);
            ViewBag.bedcount = values2.bedroomCount;
            ViewBag.size = values2.productSize;
            ViewBag.roomcount = values2.roomCount;
            ViewBag.bathcount = values2.bathCount;
            ViewBag.garage = values2.garageSize;
            ViewBag.build = values2.buildYear;
            ViewBag.date = values2.ProductDate;
            ViewBag.location = values2.location;
            ViewBag.videourl = values2.videoUrl;

            return View(values);
        }

        public async Task<IActionResult> PropertyListWithSearch(string searchKeyValue, int propertyCategoryId, string city)
        {
            searchKeyValue = TempData["searchKeyValue"].ToString();
            propertyCategoryId = int.Parse(TempData["propertyCategoryId"].ToString());
            city = TempData["city"].ToString();
            var client = _httpClientFactory.CreateClient("MyApiClient");
            var responseMessage = await client.GetAsync($"Products/ResultProductWithSearchFilters?searchKeyValue={searchKeyValue}&propertyCategoryId={propertyCategoryId}&city={city}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductWithSearchFiltersDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
