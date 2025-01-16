using DopamineDetox.Domain.Dtos;
using DopamineDetox.ServiceAgent.Interfaces;
using DopamineDetox.ServiceAgent.Models.Responses;
using DopamineDetox.ServiceAgent.Requests;

namespace DopamineDetox.ServiceAgent.Services
{
    public class TopicService : ITopicService
    {
        private readonly IApiService _apiService;
        private const string BaseEndpoint = "api/Topic";

        public TopicService(IApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<ApiResponse<IEnumerable<TopicDto>>> GetTopicsAsync(GetTopicsRequest request, CancellationToken cancellationToken)
        {
            return await _apiService.PostAsync<IEnumerable<TopicDto>>($"{BaseEndpoint}/search", request, cancellationToken);
        }

        public async Task<ApiResponse<TopicDto>> GetTopicAsync(int id, CancellationToken cancellationToken)
        {
            return await _apiService.GetAsync<TopicDto>($"{BaseEndpoint}/{id}", cancellationToken);
        }

        public async Task<ApiResponse<TopicDto>> CreateTopicAsync(TopicDto topicDto, CancellationToken cancellationToken)
        {
            return await _apiService.PostAsync<TopicDto>(BaseEndpoint, topicDto, cancellationToken);
        }

        public async Task<ApiResponse<TopicDto>> UpdateTopicAsync(int id, TopicDto topicDto, CancellationToken cancellationToken)
        {
            return await _apiService.PutAsync<TopicDto>($"{BaseEndpoint}/{id}", topicDto, cancellationToken);
        }

        public async Task<ApiResponse<bool>> DeleteTopicAsync(int id, CancellationToken cancellationToken)
        {
            return await _apiService.DeleteAsync<bool>($"{BaseEndpoint}/{id}", cancellationToken);
        }

        public async Task<ApiResponse<bool>> InactivateTopicAsync(int id, CancellationToken cancellationToken)
        {
            return await _apiService.PatchAsync<bool>($"{BaseEndpoint}/{id}/inactivate", null, cancellationToken);
        }
    }
}