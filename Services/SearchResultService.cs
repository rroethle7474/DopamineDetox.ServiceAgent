using DopamineDetox.Domain.Dtos;
using DopamineDetox.ServiceAgent.Interfaces;
using DopamineDetox.ServiceAgent.Models.Responses;
using DopamineDetox.ServiceAgent.Requests;

namespace DopamineDetox.ServiceAgent.Services
{
    public class SearchResultService : ISearchResultService
    {
        private readonly IApiService _apiService;
        private const string BaseEndpoint = "api/SearchResult";

        public SearchResultService(IApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<ApiResponse<IEnumerable<SearchResultDto>>> GetSearchResultsAsync(GetSearchResultsRequest request, CancellationToken cancellationToken)
        {
            return await _apiService.PostAsync<IEnumerable<SearchResultDto>>($"{BaseEndpoint}/search", request, cancellationToken);
        }

            public async Task<ApiResponse<SearchResultDto>> GetSearchResultAsync(int id, CancellationToken cancellationToken)
        {
            return await _apiService.GetAsync<SearchResultDto>($"{BaseEndpoint}/{id}", cancellationToken);
        }

        public async Task<ApiResponse<SearchResultDto>> CreateSearchResultAsync(SearchResultDto searchResultDto, CancellationToken cancellationToken)
        {
            return await _apiService.PostAsync<SearchResultDto>(BaseEndpoint, searchResultDto, cancellationToken);
        }

        public async Task<ApiResponse<SearchResultsResponseDto>> AddMultipleSearchResultsAsync(IEnumerable<SearchResultDto> searchResults, CancellationToken cancellationToken)
        {
            return await _apiService.PostAsync<SearchResultsResponseDto>($"{BaseEndpoint}/AddMultipleSearchResults", searchResults, cancellationToken);
        }

        public async Task<ApiResponse<SearchResultDto>> UpdateSearchResultAsync(int id, SearchResultDto searchResultDto, CancellationToken cancellationToken)
        {
            return await _apiService.PutAsync<SearchResultDto>($"{BaseEndpoint}/{id}", searchResultDto, cancellationToken);
        }

        public async Task<ApiResponse<bool>> DeleteSearchResultAsync(int id, CancellationToken cancellationToken)
        {
            return await _apiService.DeleteAsync<bool>($"{BaseEndpoint}/{id}", cancellationToken);
        }

        public async Task<ApiResponse<bool>> DeleteSearchResultsByDate(DateTime date, bool isBefore, CancellationToken cancellationToken)
        {
            return await _apiService.DeleteAsync<bool>($"{BaseEndpoint}/deleteByDate?date={date:O}&isBefore={isBefore}", cancellationToken);
        }
    }
}