using DopamineDetox.Domain.Dtos;
using DopamineDetox.ServiceAgent.Interfaces;
using DopamineDetox.ServiceAgent.Models.Responses;

namespace DopamineDetox.ServiceAgent.Services
{
    public class DefaultTopicService : IDefaultTopicService
    {
        private readonly IApiService _apiService;
        private const string BaseEndpoint = "api/DefaultTopic";

        public DefaultTopicService(IApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<ApiResponse<IEnumerable<DefaultTopicDto>>> GetDefaultTopicsAsync(CancellationToken cancellationToken)
        {
            return await _apiService.GetAsync<IEnumerable<DefaultTopicDto>>($"{BaseEndpoint}/all", cancellationToken);
        }
    }
}