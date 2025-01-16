using DopamineDetox.Domain.Dtos;
using DopamineDetox.ServiceAgent.Models.Responses;
using DopamineDetox.ServiceAgent.Requests;

namespace DopamineDetox.ServiceAgent.Interfaces
{
    public interface IChannelService
    {
        Task<ApiResponse<IEnumerable<ChannelDto>>> GetChannelsAsync(GetChannelsRequest request, CancellationToken cancellationToken);
        Task<ApiResponse<ChannelDto>> GetChannelAsync(int id, CancellationToken cancellationToken);
        Task<ApiResponse<ChannelDto>> CreateChannelAsync(ChannelDto channelDto, CancellationToken cancellationToken);
        Task<ApiResponse<ChannelDto>> UpdateChannelAsync(int id, ChannelDto channelDto, CancellationToken cancellationToken);
        Task<ApiResponse<bool>> DeleteChannelAsync(int id, CancellationToken cancellationToken);
    }
}
