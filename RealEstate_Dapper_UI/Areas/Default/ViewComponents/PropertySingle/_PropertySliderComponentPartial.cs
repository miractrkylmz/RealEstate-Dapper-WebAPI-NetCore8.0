using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_Dapper_UI.DTOs.ProductImageDTOs;

namespace RealEstate_Dapper_UI.Areas.Default.ViewComponents.PropertySingle
{
    public class _PropertySliderComponentPartial(IHttpClientFactory _clientFactory):ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var client = _clientFactory.CreateClient("MyApiClient");
            var responseMessage = await client.GetAsync($"ProductImage/GetProductImages?id={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<GetProductImagesDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
