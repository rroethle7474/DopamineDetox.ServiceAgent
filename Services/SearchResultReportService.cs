using DopamineDetox.Domain.Dtos;
using DopamineDetox.ServiceAgent.Interfaces;
using DopamineDetox.ServiceAgent.Models.Responses;
using DopamineDetox.ServiceAgent.Requests;

namespace DopamineDetox.ServiceAgent.Services
{
    public class SearchResultReportService : ISearchResultReportService
    {
        private readonly IApiService _apiService;
        private const string BaseEndpoint = "api/SearchResultReport";

        public SearchResultReportService(IApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<ApiResponse<IEnumerable<SearchResultReportDto>>> GetSearchResultReportsAsync(GetSearchResultReportRequest request, CancellationToken cancellationToken)
        {
            return await _apiService.PostAsync<IEnumerable<SearchResultReportDto>>($"{BaseEndpoint}/search", request, cancellationToken);
        }

        public async Task<ApiResponse<SearchResultReportDto>> GetSearchResultReportAsync(int id, CancellationToken cancellationToken)
        {
            return await _apiService.GetAsync<SearchResultReportDto>($"{BaseEndpoint}/{id}", cancellationToken);
        }

        public async Task<ApiResponse<SearchResultReportDto>> CreateSearchResultReportAsync(SearchResultReportDto searchResultReportDto, CancellationToken cancellationToken)
        {
            return await _apiService.PostAsync<SearchResultReportDto>(BaseEndpoint, searchResultReportDto, cancellationToken);
        }

        public async Task<ApiResponse<SearchResultReportDto>> UpdateSearchResultReportAsync(int id, SearchResultReportDto searchResultReportDto, CancellationToken cancellationToken)
        {
            return await _apiService.PutAsync<SearchResultReportDto>($"{BaseEndpoint}/{id}", searchResultReportDto, cancellationToken);
        }

        public async Task<ApiResponse<bool>> DeleteSearchResultReportAsync(int id, CancellationToken cancellationToken)
        {
            return await _apiService.DeleteAsync<bool>($"{BaseEndpoint}/{id}", cancellationToken);
        }

        public async Task<ApiResponse<bool>> DeleteSearchResultReportsByDate(DateTime date, bool isBefore, CancellationToken cancellationToken)
        {
            return await _apiService.DeleteAsync<bool>($"{BaseEndpoint}/deleteByDate?date={date:O}&isBefore={isBefore}", cancellationToken);
        }
    }
}
