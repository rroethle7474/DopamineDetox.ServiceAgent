using DopamineDetox.Domain.Dtos;
using DopamineDetox.ServiceAgent.Interfaces;
using DopamineDetox.ServiceAgent.Models.Responses;

namespace DopamineDetox.ServiceAgent.Services
{
    public class QuoteService : IQuoteService
    {
        private readonly IApiService _apiService;
        private const string BaseEndpoint = "api/Quote";

        public QuoteService(IApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<ApiResponse<QuoteDto>> GetDailyQuote(CancellationToken cancellationToken)
        {
            return await _apiService.GetAsync<QuoteDto>($"{BaseEndpoint}/daily", cancellationToken);
        }

        public async Task<ApiResponse<LearnMoreDetailDto>> GetDailyLearnMoreDetails(CancellationToken cancellationToken)
        {
            return await _apiService.GetAsync<LearnMoreDetailDto>($"{BaseEndpoint}/learn-more", cancellationToken);
        }

        public async Task<ApiResponse<bool>> CreateDailyQuote(CancellationToken cancellationToken)
        {
            return await _apiService.GetAsync<bool>($"{BaseEndpoint}/create-daily", cancellationToken);
        }

        public async Task<ApiResponse<bool>> CreateDailyLearnMoreDetails(CancellationToken cancellationToken)
        {
            return await _apiService.GetAsync<bool>($"{BaseEndpoint}/create-learn-more", cancellationToken);
        }
    }
}
