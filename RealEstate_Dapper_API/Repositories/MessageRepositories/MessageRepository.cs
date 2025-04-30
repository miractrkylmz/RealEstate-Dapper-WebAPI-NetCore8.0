using Dapper;
using RealEstate_Dapper_API.DTOs.MessageDTOs;
using RealEstate_Dapper_API.Models.DapperContext;
using System.Reflection;
using System.Threading;

namespace RealEstate_Dapper_API.Repositories.MessageRepositories
{
    public class MessageRepository(Context _context) : IMessageRepository
    {
        public async Task<List<ResultInboxMessageDto>> GetInboxLast3MessageListByReceiver(int id)
        {
            string query = "Select Top(3) MessageID,Name,Subject,Detail,SendDate,IsRead,UserImageUrl from Message inner join AppUser on Message.Sender = AppUser.UserID where Receiver = 1 order By MessageID Desc";
            using var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultInboxMessageDto>(query, new {receiverid=id});
            return values.ToList();
        }
    }
}
