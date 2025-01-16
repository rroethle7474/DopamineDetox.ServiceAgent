using DopamineDetox.ServiceAgent.Interfaces;
using DopamineDetox.ServiceAgent.Models.Responses;
using DopamineDetox.ServiceAgent.Requests;

namespace DopamineDetox.ServiceAgent.Services
{
    public class CloudEmailService : ICloudEmailService
    {
        private readonly IApiService _apiService;
        private const string BaseEndpoint = "api/Email";

        public CloudEmailService(IApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<ApiResponse<bool>> SendEmailAsync(SendEmailRequest request, CancellationToken cancellationToken)
        {
            return await _apiService.PostAsync<bool>($"{BaseEndpoint}/send", request, cancellationToken);
        }
        public async Task<ApiResponse<bool>> SendMVPUserWeeklyEmails(SendMVPEmailRequest request, CancellationToken cancellationToken)
        {
            return await _apiService.PostAsync<bool>($"{BaseEndpoint}/mvpweeklyreport", request, cancellationToken);
        }
    }
}