using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_Dapper_UI.DTOs.AppUserDTOs;

namespace RealEstate_Dapper_UI.Areas.Default.ViewComponents.PropertySingle
{
    public class _PropertyAppUserComponentPartial(IHttpClientFactory _clientFactory):ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _clientFactory.CreateClient("MyApiClient");
            var responseMessage = await client.GetAsync("AppUsers?id=1");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<GetAppUserByProductIDDto>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}