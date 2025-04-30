using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_UI.Services;
using System.Net.Http;

namespace RealEstate_Dapper_UI.Areas.EstateAgent.ViewComponents
{
    public class _DashboardStatisticComponentPartial(IHttpClientFactory _httpClientFactory, ILoginService _loginService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var id = _loginService.GetUserId;
            var client = _httpClientFactory.CreateClient("MyApiClient");

            #region Statistics1 - Toplam İlan Sayısı
            var responseMessage1 = await client.GetAsync("EstateAgentDashboardStatistic/AllProductCount");
            var jsonData1 = await responseMessage1.Content.ReadAsStringAsync();
            ViewBag.productCount = jsonData1;
            #endregion

            #region Statistics2 - Emlakçının Toplam İlan Sayısı
            var responseMessage2 = await client.GetAsync($"EstateAgentDashboardStatistic/ProductCountByEmployeeId?id={id}");
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.productCountByEmployee = jsonData2;
            #endregion

            #region Statistics3 - Emlakçının Aktif İlan Sayısı
            var responseMessage3 = await client.GetAsync($"EstateAgentDashboardStatistic/ProductCountByStatusTrue?id={id}");
            var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.activeProductCountByStatusTrue = jsonData3;
            #endregion

            #region Statistics4 - Emlakçının Pasif İlan Sayısı
            var responseMessage4 = await client.GetAsync($"EstateAgentDashboardStatistic/ProductCountByStatusFalse?id={id}");
            var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
            ViewBag.activeProductCountByStatusFalse = jsonData4;
            #endregion
            return View();
        }
    }
}
