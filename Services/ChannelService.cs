using DopamineDetox.Domain.Dtos;
using DopamineDetox.ServiceAgent.Interfaces;
using DopamineDetox.ServiceAgent.Models.Responses;
using DopamineDetox.ServiceAgent.Requests;

namespace DopamineDetox.ServiceAgent.Services
{
    public class ChannelService : IChannelService
    {
        private readonly IApiService _apiService;
        private const string BaseEndpoint = "api/Channel";

        public ChannelService(IApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<ApiResponse<IEnumerable<ChannelDto>>> GetChannelsAsync(GetChannelsRequest request, CancellationToken cancellationToken)
        {
            return await _apiService.PostAsync<IEnumerable<ChannelDto>>($"{BaseEndpoint}/search", request, cancellationToken);
        }

        public async Task<ApiResponse<ChannelDto>> GetChannelAsync(int id, CancellationToken cancellationToken)
        {
            return await _apiService.GetAsync<ChannelDto>($"{BaseEndpoint}/{id}", cancellationToken);
        }

        public async Task<ApiResponse<ChannelDto>> CreateChannelAsync(ChannelDto channelDto, CancellationToken cancellationToken)
        {
            return await _apiService.PostAsync<ChannelDto>(BaseEndpoint, channelDto, cancellationToken);
        }

        public async Task<ApiResponse<ChannelDto>> UpdateChannelAsync(int id, ChannelDto channelDto, CancellationToken cancellationToken)
        {
            return await _apiService.PutAsync<ChannelDto>($"{BaseEndpoint}/{id}", channelDto, cancellationToken);
        }

        public async Task<ApiResponse<bool>> DeleteChannelAsync(int id, CancellationToken cancellationToken)
        {
            return await _apiService.DeleteAsync<bool>($"{BaseEndpoint}/{id}", cancellationToken);
        }
    }
}