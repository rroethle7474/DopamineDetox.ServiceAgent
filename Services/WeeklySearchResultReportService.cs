using DopamineDetox.Domain.Dtos;
using DopamineDetox.ServiceAgent.Interfaces;
using DopamineDetox.ServiceAgent.Models.Responses;
using DopamineDetox.ServiceAgent.Requests;

namespace DopamineDetox.ServiceAgent.Services
{
    public class WeeklySearchResultReportService : IWeeklySearchResultReportService
    {
        private readonly IApiService _apiService;
        private const string BaseEndpoint = "api/WeeklySearchResultReport";

        public WeeklySearchResultReportService(IApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<ApiResponse<IEnumerable<WeeklySearchResultReportDto>>> GetWeeklySearchResultReportsAsync(GetWeeklySearchResultReportsRequest request, CancellationToken cancellationToken)
        {
            return await _apiService.PostAsync<IEnumerable<WeeklySearchResultReportDto>>($"{BaseEndpoint}/search", request, cancellationToken);
        }

        public async Task<ApiResponse<WeeklySearchResultReportDto>> GetWeeklySearchResultReportAsync(int id, CancellationToken cancellationToken)
        {
            return await _apiService.GetAsync<WeeklySearchResultReportDto>($"{BaseEndpoint}/{id}", cancellationToken);
        }

        public async Task<ApiResponse<WeeklySearchResultReportDto>> CreateWeeklySearchResultReportAsync(WeeklySearchResultReportDto weeklySearchResultReportDto, CancellationToken cancellationToken)
        {
            return await _apiService.PostAsync<WeeklySearchResultReportDto>(BaseEndpoint, weeklySearchResultReportDto, cancellationToken);
        }

        public async Task<ApiResponse<WeeklySearchResultReportDto>> UpdateWeeklySearchResultReportAsync(int id, WeeklySearchResultReportDto weeklySearchResultReportDto, CancellationToken cancellationToken)
        {
            return await _apiService.PutAsync<WeeklySearchResultReportDto>($"{BaseEndpoint}/{id}", weeklySearchResultReportDto, cancellationToken);
        }

        public async Task<ApiResponse<bool>> DeleteWeeklySearchResultReportAsync(int id, CancellationToken cancellationToken)
        {
            return await _apiService.DeleteAsync<bool>($"{BaseEndpoint}/{id}", cancellationToken);
        }

        public async Task<ApiResponse<bool>> EmailUserWeeklyReport(string userId, CancellationToken cancellationToken)
        {
            return await _apiService.PostAsync<bool>($"{BaseEndpoint}/email/{userId}", null, cancellationToken);
        }
    }
}
