using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_API.Repositories.MessageRepositories;

namespace RealEstate_Dapper_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController(IMessageRepository _message) : ControllerBase
    {
        [HttpGet("GetInboxLast3MessageListByReceiver")]
        public async Task<IActionResult> Last3MessagesByReceiver(int id)
        {
            var values = await _message.GetInboxLast3MessageListByReceiver(id);
            return Ok(values);
        }
    }
}
