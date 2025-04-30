using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_Dapper_UI.DTOs.ProductDTOs;

namespace RealEstate_Dapper_UI.Areas.Admin.ViewComponents.Dashboard
{
    public class _DashboardLast5ProductComponentPartial(IHttpClientFactory _clientFactory) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _clientFactory.CreateClient("MyApiClient");

            var request = new HttpRequestMessage(HttpMethod.Get, "Products/Last5ProductList");
            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultLast5PRoductWithCategoryDTO>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
