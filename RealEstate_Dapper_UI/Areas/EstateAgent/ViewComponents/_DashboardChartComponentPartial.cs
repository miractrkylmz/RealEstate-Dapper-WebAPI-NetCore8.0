using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_Dapper_UI.DTOs.EstateAgentDTOs;

namespace RealEstate_Dapper_UI.Areas.EstateAgent.ViewComponents
{
    public class _DashboardChartComponentPartial(IHttpClientFactory _clientFactory) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _clientFactory.CreateClient("MyApiClient");
            var responseMessage = await client.GetAsync("EstateAgentChart");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultEstateAgentDashboardChartDTO>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
