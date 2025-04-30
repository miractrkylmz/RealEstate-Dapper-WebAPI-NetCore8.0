using Microsoft.AspNetCore.SignalR;

namespace RealEstate_Dapper_API.Hubs
{
    public class SignalRHub(IHttpClientFactory _httpClientFactory) : Hub
    {
        public async Task SendCategoryCount()
        {
            var client1 = _httpClientFactory.CreateClient("MyApiClient");
            var responseMessage1 = await client1.GetAsync("Statistics/CategoryCount");
            var jsonData1 = await responseMessage1.Content.ReadAsStringAsync();
            await Clients.All.SendAsync("ReceiveCategoryCount",jsonData1);
        }
    }
}
