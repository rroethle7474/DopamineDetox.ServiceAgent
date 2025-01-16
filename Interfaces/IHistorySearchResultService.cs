using DopamineDetox.Domain.Dtos;
using DopamineDetox.ServiceAgent.Models.Responses;

namespace DopamineDetox.ServiceAgent.Interfaces
{
    public interface IHistorySearchResultService
    {
        Task<ApiResponse<IEnumerable<HistorySearchResultDto>>> GetHistorySearchResultsAsync(CancellationToken cancellationToken);
        Task<ApiResponse<HistorySearchResultDto>> GetHistorySearchResultAsync(int id, CancellationToken cancellationToken);
        Task<ApiResponse<HistorySearchResultDto>> CreateHistorySearchResultAsync(HistorySearchResultDto historySearchResultDto, CancellationToken cancellationToken);
        Task<ApiResponse<HistorySearchResultDto>> UpdateHistorySearchResultAsync(int id, HistorySearchResultDto historySearchResultDto, CancellationToken cancellationToken);
        Task<ApiResponse<bool>> DeleteHistorySearchResultAsync(int id, CancellationToken cancellationToken);
    }
}
