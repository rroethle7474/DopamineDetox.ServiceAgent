using DopamineDetox.ServiceAgent.Exceptions;
using DopamineDetox.ServiceAgent.Interfaces;
using DopamineDetox.ServiceAgent.Models.Responses;
using System.Text;
using System.Text.Json;

namespace DopamineDetox.ServiceAgent.Services
{
    public class ApiService : IApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ApiResponse<T>> GetAsync<T>(string endpoint, CancellationToken cancellationToken = default)
        {
            try
            {
                var response = await _httpClient.GetAsync(endpoint, cancellationToken);
                return await ProcessResponseAsync<T>(response);
            }
            catch (Exception ex)
            {
                return HandleException<T>(ex);
            }
        }

        public async Task<ApiResponse<T>> PostAsync<T>(string endpoint, object data, CancellationToken cancellationToken = default)
        {
            try
            {
                var json = JsonSerializer.Serialize(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync(endpoint, content, cancellationToken);
                return await ProcessResponseAsync<T>(response);
            }
            catch (Exception ex)
            {
                return HandleException<T>(ex);
            }
        }

        public async Task<ApiResponse<T>> PutAsync<T>(string endpoint, object data, CancellationToken cancellationToken = default)
        {
            try
            {
                var json = JsonSerializer.Serialize(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await _httpClient.PutAsync(endpoint, content, cancellationToken);
                return await ProcessResponseAsync<T>(response);
            }
            catch (Exception ex)
            {
                return HandleException<T>(ex);
            }
        }

        public async Task<ApiResponse<T>> PatchAsync<T>(string endpoint, object data, CancellationToken cancellationToken = default)
        {
            var json = JsonSerializer.Serialize(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var request = new HttpRequestMessage(HttpMethod.Patch, endpoint) { Content = content };
            var response = await _httpClient.SendAsync(request, cancellationToken);
            return await ProcessResponseAsync<T>(response);
        }

        public async Task<ApiResponse<T>> DeleteAsync<T>(string endpoint, CancellationToken cancellationToken = default)
        {
            try
            {
                var response = await _httpClient.DeleteAsync(endpoint, cancellationToken);
                return await ProcessResponseAsync<T>(response);
            }
            catch (Exception ex)
            {
                return HandleException<T>(ex);
            }
        }

        private async Task<ApiResponse<T>> ProcessResponseAsync<T>(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<T>(content);
                return ApiResponse<T>.SuccessResult(data);
            }
            else
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                var errorMessage = $"HTTP {(int)response.StatusCode} - {response.ReasonPhrase}: {errorContent}";
                return ApiResponse<T>.FailureResult(errorMessage);
            }
        }

        private ApiResponse<T> HandleException<T>(Exception ex)
        {
            var serviceAgentException = new ServiceAgentException("An error occurred while processing the request.", ex);
            return ApiResponse<T>.FailureResult(serviceAgentException.Message, serviceAgentException);
        }
    }
}