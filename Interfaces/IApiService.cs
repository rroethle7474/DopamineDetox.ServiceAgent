using DopamineDetox.ServiceAgent.Models.Responses;

namespace DopamineDetox.ServiceAgent.Interfaces
{
    public interface IApiService
    {
        Task<ApiResponse<T>> GetAsync<T>(string endpoint, CancellationToken cancellationToken=default);
        Task<ApiResponse<T>> PostAsync<T>(string endpoint, object data, CancellationToken cancellationToken = default);
        Task<ApiResponse<T>> PutAsync<T>(string endpoint, object data, CancellationToken cancellationToken = default);
        Task<ApiResponse<T>> PatchAsync<T>(string endpoint, object data, CancellationToken cancellationToken = default);
        Task<ApiResponse<T>> DeleteAsync<T>(string endpoint, CancellationToken cancellationToken = default);
    }
}
