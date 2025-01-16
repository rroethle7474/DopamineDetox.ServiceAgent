using DopamineDetox.Domain.Dtos;
using DopamineDetox.ServiceAgent.Models.Responses;
using DopamineDetox.ServiceAgent.Requests;

namespace DopamineDetox.ServiceAgent.Interfaces
{
    public interface ITopicService
    {
        Task<ApiResponse<IEnumerable<TopicDto>>> GetTopicsAsync(GetTopicsRequest request, CancellationToken cancellationToken);
        Task<ApiResponse<TopicDto>> GetTopicAsync(int id, CancellationToken cancellationToken);
        Task<ApiResponse<TopicDto>> CreateTopicAsync(TopicDto topicDto, CancellationToken cancellationToken);
        Task<ApiResponse<TopicDto>> UpdateTopicAsync(int id, TopicDto topicDto, CancellationToken cancellationToken);
        Task<ApiResponse<bool>> DeleteTopicAsync(int id, CancellationToken cancellationToken);
        Task<ApiResponse<bool>> InactivateTopicAsync(int id, CancellationToken cancellationToken);
    }
}
