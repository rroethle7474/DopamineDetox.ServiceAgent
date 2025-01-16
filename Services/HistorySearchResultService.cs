using DopamineDetox.Domain.Dtos;
using DopamineDetox.ServiceAgent.Interfaces;
using DopamineDetox.ServiceAgent.Models.Responses;

namespace DopamineDetox.ServiceAgent.Services
{
    public class HistorySearchResultService : IHistorySearchResultService
    {
        private readonly IApiService _apiService;
        private const string BaseEndpoint = "api/HistorySearchResult";

        public HistorySearchResultService(IApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<ApiResponse<IEnumerable<HistorySearchResultDto>>> GetHistorySearchResultsAsync(CancellationToken cancellationToken)
        {
            return await _apiService.GetAsync<IEnumerable<HistorySearchResultDto>>(BaseEndpoint, cancellationToken);
        }

        public async Task<ApiResponse<HistorySearchResultDto>> GetHistorySearchResultAsync(int id, CancellationToken cancellationToken)
        {
            return await _apiService.GetAsync<HistorySearchResultDto>($"{BaseEndpoint}/{id}", cancellationToken);
        }

        public async Task<ApiResponse<HistorySearchResultDto>> CreateHistorySearchResultAsync(HistorySearchResultDto historySearchResultDto, CancellationToken cancellationToken)
        {
            return await _apiService.PostAsync<HistorySearchResultDto>(BaseEndpoint, historySearchResultDto, cancellationToken);
        }

        public async Task<ApiResponse<HistorySearchResultDto>> UpdateHistorySearchResultAsync(int id, HistorySearchResultDto historySearchResultDto, CancellationToken cancellationToken)
        {
            return await _apiService.PutAsync<HistorySearchResultDto>($"{BaseEndpoint}/{id}", historySearchResultDto, cancellationToken);
        }

        public async Task<ApiResponse<bool>> DeleteHistorySearchResultAsync(int id, CancellationToken cancellationToken)
        {
            return await _apiService.DeleteAsync<bool>($"{BaseEndpoint}/{id}", cancellationToken);
        }
    }
}
