using DopamineDetox.Domain.Dtos;
using DopamineDetox.ServiceAgent.Models.Responses;
using DopamineDetox.ServiceAgent.Requests;

namespace DopamineDetox.ServiceAgent.Interfaces
{
    public interface ISearchResultReportService
    {
        Task<ApiResponse<IEnumerable<SearchResultReportDto>>> GetSearchResultReportsAsync(GetSearchResultReportRequest request, CancellationToken cancellationToken);
        Task<ApiResponse<SearchResultReportDto>> GetSearchResultReportAsync(int id, CancellationToken cancellationToken);
        Task<ApiResponse<SearchResultReportDto>> CreateSearchResultReportAsync(SearchResultReportDto searchResultReportDto, CancellationToken cancellationToken);
        Task<ApiResponse<SearchResultReportDto>> UpdateSearchResultReportAsync(int id, SearchResultReportDto searchResultReportDto, CancellationToken cancellationToken);
        Task<ApiResponse<bool>> DeleteSearchResultReportAsync(int id, CancellationToken cancellationToken);
        Task<ApiResponse<bool>> DeleteSearchResultReportsByDate(DateTime startingDate, bool isBefore, CancellationToken cancellationToken);
    }
}
