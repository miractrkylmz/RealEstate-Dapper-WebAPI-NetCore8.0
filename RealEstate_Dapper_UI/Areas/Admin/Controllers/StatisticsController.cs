using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers;
using Newtonsoft.Json;

namespace RealEstate_Dapper_UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StatisticsController(IHttpClientFactory _httpClientFactory) : Controller
    {
        public async Task<IActionResult> Index()
        {
            #region Statistics1
            var client1 = _httpClientFactory.CreateClient("MyApiClient");
            var responseMessage = await client1.GetAsync("Statistics/ActiveCategoryCount");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.activeCategoryCount = jsonData;
            #endregion

            #region Statistics2
            var client2 = _httpClientFactory.CreateClient("MyApiClient");
            var responseMessage2 = await client2.GetAsync("Statistics/ActiveEmployeeCount");
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.activeEmployeeCount = jsonData2;
            #endregion

            #region Statistics3
            var client3 = _httpClientFactory.CreateClient("MyApiClient");
            var responseMessage3 = await client3.GetAsync("Statistics/ApartmantCount");
            var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.apartmantCount = jsonData3;
            #endregion

            #region Statistics4
            var client4 = _httpClientFactory.CreateClient("MyApiClient");
            var responseMessage4 = await client4.GetAsync("Statistics/AvgProductPriceByRent");
            var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
            ViewBag.avgProductPriceByRent = jsonData4;
            #endregion

            #region Statistics5
            var client5 = _httpClientFactory.CreateClient("MyApiClient");
            var responseMessage5 = await client5.GetAsync("Statistics/AvgProductPriceBySale");
            var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
            ViewBag.avgProductPriceBySale = jsonData5;
            #endregion

            #region Statistics6
            var client6 = _httpClientFactory.CreateClient("MyApiClient");
            var responseMessage6 = await client6.GetAsync("Statistics/AvgRoomCount");
            var jsonData6 = await responseMessage6.Content.ReadAsStringAsync();
            ViewBag.avgRoomCount = jsonData6;
            #endregion

            #region Statistics7
            var client7 = _httpClientFactory.CreateClient("MyApiClient");
            var responseMessage7 = await client7.GetAsync("Statistics/CategoryCount");
            var jsonData7 = await responseMessage7.Content.ReadAsStringAsync();
            ViewBag.categoryCount = jsonData7;
            #endregion

            #region Statistics8
            var client8 = _httpClientFactory.CreateClient("MyApiClient");
            var responseMessage8 = await client8.GetAsync("Statistics/CategoryNameByMaxProductCount");
            var jsonData8 = await responseMessage8.Content.ReadAsStringAsync();
            ViewBag.categoryNameByMaxProductCount = jsonData8;
            #endregion

            #region Statistics9
            var client9 = _httpClientFactory.CreateClient("MyApiClient");
            var responseMessage9 = await client9.GetAsync("Statistics/CityNameByMaxProductCount");
            var jsonData9 = await responseMessage9.Content.ReadAsStringAsync();
            ViewBag.cityNameByMaxProductCount = jsonData9;
            #endregion

            #region Statistics10
            var client10 = _httpClientFactory.CreateClient("MyApiClient");
            var responseMessage10 = await client10.GetAsync("Statistics/DifferentCities");
            var jsonData10 = await responseMessage10.Content.ReadAsStringAsync();
            ViewBag.differentCities = jsonData10;
            #endregion

            #region Statistics11
            var client11 = _httpClientFactory.CreateClient("MyApiClient");
            var responseMessage11 = await client11.GetAsync("Statistics/EmployeeNameByMaxProductCount");
            var jsonData11 = await responseMessage11.Content.ReadAsStringAsync();
            ViewBag.employeeNameByMaxProductCount = jsonData11;
            #endregion

            #region Statistics12
            var client12 = _httpClientFactory.CreateClient("MyApiClient");
            var responseMessage12 = await client12.GetAsync("Statistics/LastProductPrice");
            var jsonData12 = await responseMessage12.Content.ReadAsStringAsync();
            ViewBag.lastProductPrice = jsonData12;
            #endregion

            #region Statistics13
            var client13 = _httpClientFactory.CreateClient("MyApiClient");
            var responseMessage13 = await client13.GetAsync("Statistics/NewestBuildingYear");
            var jsonData13 = await responseMessage13.Content.ReadAsStringAsync();
            ViewBag.newestBuildingYear = jsonData13;
            #endregion

            #region Statistics14
            var client14 = _httpClientFactory.CreateClient("MyApiClient");
            var responseMessage14 = await client14.GetAsync("Statistics/OldestBuildingYear");
            var jsonData14 = await responseMessage14.Content.ReadAsStringAsync();
            ViewBag.oldestBuildingYear = jsonData14;
            #endregion

            #region Statistics15
            var client15 = _httpClientFactory.CreateClient("MyApiClient");
            var responseMessage15 = await client15.GetAsync("Statistics/PassiveCategoryCount");
            var jsonData15 = await responseMessage15.Content.ReadAsStringAsync();
            ViewBag.passiveCategoryCount = jsonData15;
            #endregion

            #region Statistics16
            var client16 = _httpClientFactory.CreateClient("MyApiClient");
            var responseMessage16 = await client16.GetAsync("Statistics/ProductCount");
            var jsonData16 = await responseMessage16.Content.ReadAsStringAsync();
            ViewBag.productCount = jsonData16;
            #endregion


            return View();
        }
    }
}
