using DopamineDetox.Domain.Dtos;
using DopamineDetox.ServiceAgent.Interfaces;
using DopamineDetox.ServiceAgent.Models.Responses;
using DopamineDetox.ServiceAgent.Requests;

namespace DopamineDetox.ServiceAgent.Services
{
    public class TopSearchResultService : ITopSearchResultService
    {
        private readonly IApiService _apiService;
        private const string BaseEndpoint = "api/TopSearchResult";

        public TopSearchResultService(IApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<ApiResponse<IEnumerable<TopSearchResultDto>>> GetTopSearchResultsAsync(GetTopSearchResultsRequest request, CancellationToken cancellationToken)
        {
            return await _apiService.PostAsync<IEnumerable<TopSearchResultDto>>(BaseEndpoint, request, cancellationToken);
        }

        public async Task<ApiResponse<TopSearchResultDto>> GetTopSearchResultAsync(int id, CancellationToken cancellationToken)
        {
            return await _apiService.GetAsync<TopSearchResultDto>($"{BaseEndpoint}/{id}", cancellationToken);
        }


        public async Task<ApiResponse<IEnumerable<string>>> GetTopSearchResultsNoteList(CancellationToken cancellationToken)
        {
            return await _apiService.GetAsync<IEnumerable<string>>($"{BaseEndpoint}/user-list", cancellationToken);
        }

        public async Task<ApiResponse<TopSearchResultDto>> CreateTopSearchResultAsync(TopSearchResultDto topSearchResultDto, CancellationToken cancellationToken)
        {
            return await _apiService.PostAsync<TopSearchResultDto>(BaseEndpoint, topSearchResultDto, cancellationToken);
        }

        public async Task<ApiResponse<TopSearchResultDto>> UpdateTopSearchResultAsync(int id, TopSearchResultDto topSearchResultDto, CancellationToken cancellationToken)
        {
            return await _apiService.PutAsync<TopSearchResultDto>($"{BaseEndpoint}/{id}", topSearchResultDto, cancellationToken);
        }

        public async Task<ApiResponse<bool>> DeleteTopSearchResultAsync(int id, CancellationToken cancellationToken)
        {
            return await _apiService.DeleteAsync<bool>($"{BaseEndpoint}/{id}", cancellationToken);
        }

        public async Task<ApiResponse<bool>> DeleteTopSearchResultsByDate(DateTime date, bool isBefore, CancellationToken cancellationToken)
        {
            return await _apiService.DeleteAsync<bool>($"{BaseEndpoint}/deleteByDate?date={date:O}&isBefore={isBefore}", cancellationToken);
        }
    }
}
