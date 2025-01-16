using DopamineDetox.Domain.Dtos;
using DopamineDetox.ServiceAgent.Models.Responses;
using DopamineDetox.ServiceAgent.Requests;

namespace DopamineDetox.ServiceAgent.Interfaces
{
    public interface ISearchResultService
    {
        Task<ApiResponse<IEnumerable<SearchResultDto>>> GetSearchResultsAsync(GetSearchResultsRequest request, CancellationToken cancellationToken);
        Task<ApiResponse<SearchResultDto>> GetSearchResultAsync(int id, CancellationToken cancellationToken);
        Task<ApiResponse<SearchResultDto>> CreateSearchResultAsync(SearchResultDto searchResultDto, CancellationToken cancellationToken);
        Task<ApiResponse<SearchResultsResponseDto>> AddMultipleSearchResultsAsync(IEnumerable<SearchResultDto> searchResultDtos, CancellationToken cancellationToken);
        Task<ApiResponse<SearchResultDto>> UpdateSearchResultAsync(int id, SearchResultDto searchResultDto, CancellationToken cancellationToken);
        Task<ApiResponse<bool>> DeleteSearchResultAsync(int id, CancellationToken cancellationToken);
        Task<ApiResponse<bool>> DeleteSearchResultsByDate(DateTime startingDate, bool isBefore, CancellationToken cancellationToken);
    }
}
