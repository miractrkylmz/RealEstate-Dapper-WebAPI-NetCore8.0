using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_API.Repositories.ToDoListRepositories;

namespace RealEstate_Dapper_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoListController(IToDoListRepository _toDoList) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> AllToDoList()
        {
            var values = await _toDoList.GetAllToDoList();
            return Ok(values);
        }
    }
}
