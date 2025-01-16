using DopamineDetox.Domain.Dtos;
using DopamineDetox.ServiceAgent.Interfaces;
using DopamineDetox.ServiceAgent.Models.Responses;

namespace DopamineDetox.ServiceAgent.Services
{
    public class LoggingService : ILoggingService
    {
        private readonly IApiService _apiService;
        private const string BaseEndpoint = "api/Logging";

        public LoggingService(IApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<ApiResponse<bool>> LogError(WebTraceDto error, CancellationToken cancellationToken)
        {
            return await _apiService.PostAsync<bool>(BaseEndpoint, error, cancellationToken);
        }
    }
}