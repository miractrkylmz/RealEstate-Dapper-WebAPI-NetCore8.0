using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_Dapper_UI.DTOs.MessageDTOs;
using RealEstate_Dapper_UI.Services;

namespace RealEstate_Dapper_UI.Areas.EstateAgent.ViewComponents.EstateAgentNavbar
{
    public class _NavbarLast3MessageComponentPartial(IHttpClientFactory _clientFactory, ILoginService _loginService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var id = _loginService.GetUserId;
            var client = _clientFactory.CreateClient("MyApiClient");
            var responseMessage = await client.GetAsync($"Messages/GetInboxLast3MessageListByReceiver?id={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultInboxMessageDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
