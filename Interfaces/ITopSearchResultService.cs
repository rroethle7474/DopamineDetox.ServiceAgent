using DopamineDetox.Domain.Dtos;
using DopamineDetox.ServiceAgent.Models.Responses;
using DopamineDetox.ServiceAgent.Requests;

namespace DopamineDetox.ServiceAgent.Interfaces
{
    public interface ITopSearchResultService
    {
        Task<ApiResponse<IEnumerable<TopSearchResultDto>>> GetTopSearchResultsAsync(GetTopSearchResultsRequest request, CancellationToken cancellationToken);
        Task<ApiResponse<TopSearchResultDto>> GetTopSearchResultAsync(int id, CancellationToken cancellationToken);
        Task<ApiResponse<TopSearchResultDto>> CreateTopSearchResultAsync(TopSearchResultDto topSearchResultDto, CancellationToken cancellationToken);
        Task<ApiResponse<TopSearchResultDto>> UpdateTopSearchResultAsync(int id, TopSearchResultDto topSearchResultDto, CancellationToken cancellationToken);
        Task<ApiResponse<bool>> DeleteTopSearchResultAsync(int id, CancellationToken cancellationToken);
        Task<ApiResponse<IEnumerable<string>>> GetTopSearchResultsNoteList(CancellationToken cancellationToken);
        Task<ApiResponse<bool>> DeleteTopSearchResultsByDate(DateTime startingDate, bool isBefore, CancellationToken cancellationToken);
    }
}
