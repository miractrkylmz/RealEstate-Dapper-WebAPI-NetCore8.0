using RealEstate_Dapper_API.DTOs.MessageDTOs;

namespace RealEstate_Dapper_API.Repositories.MessageRepositories
{
    public interface IMessageRepository
    {
        Task<List<ResultInboxMessageDto>> GetInboxLast3MessageListByReceiver(int id);
    }
}
