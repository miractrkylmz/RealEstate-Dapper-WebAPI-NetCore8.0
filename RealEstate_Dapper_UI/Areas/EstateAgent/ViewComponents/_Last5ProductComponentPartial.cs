using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_Dapper_UI.DTOs.EstateAgentDTOs;
using RealEstate_Dapper_UI.DTOs.ProductDTOs;
using RealEstate_Dapper_UI.Services;

namespace RealEstate_Dapper_UI.Areas.EstateAgent.ViewComponents
{
    public class _Last5ProductComponentPartial(IHttpClientFactory _clientFactory, ILoginService _loginService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var id = _loginService.GetUserId;
            var client = _clientFactory.CreateClient("MyApiClient");
            var responseMessage = await client.GetAsync($"EstateAgentLastProducts?id={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultLast5PRoductWithCategoryDTO>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
