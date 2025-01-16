using DopamineDetox.Domain.Dtos;
using DopamineDetox.ServiceAgent.Interfaces;
using DopamineDetox.ServiceAgent.Models.Responses;
using DopamineDetox.ServiceAgent.Requests;

namespace DopamineDetox.ServiceAgent.Services
{
    public class SubTopicService : ISubTopicService
    {
        private readonly IApiService _apiService;
        private const string BaseEndpoint = "api/SubTopic";

        public SubTopicService(IApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<ApiResponse<IEnumerable<SubTopicDto>>> GetSubTopicsAsync(GetSubTopicsRequest request, CancellationToken cancellationToken)
        {
            return await _apiService.PostAsync<IEnumerable<SubTopicDto>>($"{BaseEndpoint}/search", request, cancellationToken);
        }

        public async Task<ApiResponse<SubTopicDto>> GetSubTopicAsync(int id, CancellationToken cancellationToken)
        {
            return await _apiService.GetAsync<SubTopicDto>($"{BaseEndpoint}/{id}", cancellationToken);
        }

        public async Task<ApiResponse<SubTopicDto>> CreateSubTopicAsync(SubTopicDto subTopicDto, CancellationToken cancellationToken)
        {
            return await _apiService.PostAsync<SubTopicDto>(BaseEndpoint, subTopicDto, cancellationToken);
        }

        public async Task<ApiResponse<SubTopicDto>> UpdateSubTopicAsync(int id, SubTopicDto subTopicDto, CancellationToken cancellationToken)
        {
            return await _apiService.PutAsync<SubTopicDto>($"{BaseEndpoint}/{id}", subTopicDto, cancellationToken);
        }

        public async Task<ApiResponse<bool>> DeleteSubTopicAsync(int id, CancellationToken cancellationToken)
        {
            return await _apiService.DeleteAsync<bool>($"{BaseEndpoint}/{id}", cancellationToken);
        }

        public async Task<ApiResponse<bool>> InactivateSubTopicAsync(int id, CancellationToken cancellationToken)
        {
            return await _apiService.PatchAsync<bool>($"{BaseEndpoint}/{id}/inactivate", null, cancellationToken);
        }
    }
}