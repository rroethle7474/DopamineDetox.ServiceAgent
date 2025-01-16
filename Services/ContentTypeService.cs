using DopamineDetox.Domain.Dtos;
using DopamineDetox.ServiceAgent.Interfaces;
using DopamineDetox.ServiceAgent.Models.Responses;

namespace DopamineDetox.ServiceAgent.Services
{
    public class ContentTypeService : IContentTypeService
    {
        private readonly IApiService _apiService;
        private const string BaseEndpoint = "api/ContentType";

        public ContentTypeService(IApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<ApiResponse<IEnumerable<ContentTypeDto>>> GetContentTypesAsync(CancellationToken cancellationToken)
        {
            return await _apiService.GetAsync<IEnumerable<ContentTypeDto>>(BaseEndpoint, cancellationToken);
        }

        public async Task<ApiResponse<ContentTypeDto>> GetContentTypeAsync(int id, CancellationToken cancellationToken)
        {
            return await _apiService.GetAsync<ContentTypeDto>($"{BaseEndpoint}/{id}", cancellationToken);
        }

        public async Task<ApiResponse<ContentTypeDto>> CreateContentTypeAsync(ContentTypeDto contentTypeDto, CancellationToken cancellationToken)
        {
            return await _apiService.PostAsync<ContentTypeDto>(BaseEndpoint, contentTypeDto, cancellationToken);
        }

        public async Task<ApiResponse<ContentTypeDto>> UpdateContentTypeAsync(int id, ContentTypeDto contentTypeDto, CancellationToken cancellationToken)
        {
            return await _apiService.PutAsync<ContentTypeDto>($"{BaseEndpoint}/{id}", contentTypeDto, cancellationToken);
        }

        public async Task<ApiResponse<bool>> DeleteContentTypeAsync(int id, CancellationToken cancellationToken)
        {
            return await _apiService.DeleteAsync<bool>($"{BaseEndpoint}/{id}", cancellationToken);
        }
    }
}