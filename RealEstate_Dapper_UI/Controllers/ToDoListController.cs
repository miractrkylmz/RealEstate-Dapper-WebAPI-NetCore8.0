using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_Dapper_UI.DTOs.ToDoListDTOs;

namespace RealEstate_Dapper_UI.Controllers
{
    public class ToDoListController(IHttpClientFactory _clientFactory) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = _clientFactory.CreateClient("MyApiClient");
            var request = new HttpRequestMessage(HttpMethod.Get, "ToDoList");
            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultToDoListDTO>>(jsonData);
                return Ok(values);
            }
            return View();
        }
    }
}
