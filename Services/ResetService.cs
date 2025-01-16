using DopamineDetox.ServiceAgent.Interfaces;
using DopamineDetox.ServiceAgent.Models.Responses;

namespace DopamineDetox.ServiceAgent.Services
{
    public class ResetService : IResetService
    {
        private readonly IApiService _apiService;
        private const string BaseEndpoint = "api/Reset";

        public ResetService(IApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<ApiResponse<bool>> ClearAllCache()
        {
            return await _apiService.GetAsync<bool>($"{BaseEndpoint}/clear-cache");
        }

    }
}