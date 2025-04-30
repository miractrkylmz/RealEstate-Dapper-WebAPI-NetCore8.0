using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace RealEstate_Dapper_UI.Areas.Admin.ViewComponents.Dashboard
{
    public class _DashboardStatisticsComponentPartial(IHttpClientFactory _httpClientFactory) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient("MyApiClient");

            #region Statistics1 - Toplam İlan Sayısı
            var responseMessage1 = await client.GetAsync("Statistics/ProductCount");
            var jsonData1 = await responseMessage1.Content.ReadAsStringAsync();
            ViewBag.productCount = jsonData1;
            #endregion

            #region Statistics2 - En Başarılı Personel
            var responseMessage2 = await client.GetAsync("Statistics/EmployeeNameByMaxProductCount");
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.employeeNameByMaxProductCount = jsonData2;
            #endregion

            #region Statistics3 - İlandaki Şehir Sayısı
            var responseMessage3 = await client.GetAsync("Statistics/DifferentCities");
            var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.differentCities = jsonData3;
            #endregion

            #region Statistics4
            var responseMessage4 = await client.GetAsync("Statistics/AvgProductPriceByRent");
            var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
            ViewBag.averageProductPriceByRent = jsonData4.Replace(".", ",");
            #endregion

            return View();
        }
    }
}
