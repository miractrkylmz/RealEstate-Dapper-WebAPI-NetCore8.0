using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_Dapper_UI.DTOs.ProductDTOs;

namespace RealEstate_Dapper_UI.Areas.Default.ViewComponents.HomePage
{
    public class _DiscountOfDayComponentPartial(IHttpClientFactory _httpClientFactory) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient("MyApiClient");
            var responseMessage = await client.GetAsync("Products/GetLast3ProductListAsync");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultLast3PRoductWithCategoryDTO>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
