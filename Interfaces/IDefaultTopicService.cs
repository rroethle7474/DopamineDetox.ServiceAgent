using DopamineDetox.ServiceAgent.Models.Responses;
using DopamineDetox.Domain.Dtos;

namespace DopamineDetox.ServiceAgent.Interfaces
{
    public interface IDefaultTopicService
    {
        Task<ApiResponse<IEnumerable<DefaultTopicDto>>> GetDefaultTopicsAsync(CancellationToken cancellationToken);
    }
}
