using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_Dapper_UI.DTOs.CategoryDTOs;

namespace RealEstate_Dapper_UI.Areas.Default.Controllers
{
    [Area("Default")]
    public class DefaultController(IHttpClientFactory _clientFactory) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = _clientFactory.CreateClient("MyApiClient");
            var responseMessage = await client.GetAsync("Categories");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCategoryDTO>>(jsonData);
                return PartialView(values);
            }
            return PartialView();
        }

        [HttpPost]
        public IActionResult PartialSearch(string searchKeyValue, int propertyCategoryId, string city)
        {
            TempData["searchKeyValue"] = searchKeyValue;
            TempData["city"] = city;
            TempData["propertyCategoryId"] = propertyCategoryId;

            return RedirectToAction("PropertyListWithSearch", "Property", new
            {
                area = "Default"
            });
        }
    }
}