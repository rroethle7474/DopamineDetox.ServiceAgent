using DopamineDetox.ServiceAgent.Models.Responses;
using DopamineDetox.Domain.Dtos;

namespace DopamineDetox.ServiceAgent.Interfaces
{
    public interface ILoggingService
    {
        Task<ApiResponse<bool>> LogError(WebTraceDto error, CancellationToken cancellationToken);
    }
}