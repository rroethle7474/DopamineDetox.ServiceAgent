using DopamineDetox.Domain.Dtos;
using DopamineDetox.ServiceAgent.Models.Responses;

namespace DopamineDetox.ServiceAgent.Interfaces
{
    public interface IContentTypeService
    {
        Task<ApiResponse<IEnumerable<ContentTypeDto>>> GetContentTypesAsync(CancellationToken cancellationToken);
        Task<ApiResponse<ContentTypeDto>> GetContentTypeAsync(int id, CancellationToken cancellationToken);
        Task<ApiResponse<ContentTypeDto>> CreateContentTypeAsync(ContentTypeDto contentTypeDto, CancellationToken cancellationToken);
        Task<ApiResponse<ContentTypeDto>> UpdateContentTypeAsync(int id, ContentTypeDto contentTypeDto, CancellationToken cancellationToken);
        Task<ApiResponse<bool>> DeleteContentTypeAsync(int id, CancellationToken cancellationToken);
    }
}
