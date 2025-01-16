using DopamineDetox.Domain.Dtos;
using DopamineDetox.ServiceAgent.Models.Responses;
using DopamineDetox.ServiceAgent.Requests;

namespace DopamineDetox.ServiceAgent.Interfaces
{
    public interface ISubTopicService
    {
        Task<ApiResponse<IEnumerable<SubTopicDto>>> GetSubTopicsAsync(GetSubTopicsRequest request, CancellationToken cancellationToken);
        Task<ApiResponse<SubTopicDto>> GetSubTopicAsync(int id, CancellationToken cancellationToken);
        Task<ApiResponse<SubTopicDto>> CreateSubTopicAsync(SubTopicDto subTopicDto, CancellationToken cancellationToken);
        Task<ApiResponse<SubTopicDto>> UpdateSubTopicAsync(int id, SubTopicDto subTopicDto, CancellationToken cancellationToken);
        Task<ApiResponse<bool>> DeleteSubTopicAsync(int id, CancellationToken cancellationToken);
        Task<ApiResponse<bool>> InactivateSubTopicAsync(int id, CancellationToken cancellationToken);
    }
}