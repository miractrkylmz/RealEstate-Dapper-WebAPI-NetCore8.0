using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_Dapper_UI.DTOs.SubFeatureDTOs;

namespace RealEstate_Dapper_UI.Areas.Default.ViewComponents.HomePage
{
    public class _SubFeatureComponentPartial(IHttpClientFactory _httpClientFactory) : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient("MyApiClient");
            var responseMessage = await client.GetAsync("SubFeatures");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultSubFeatureDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}


