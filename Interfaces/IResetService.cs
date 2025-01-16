using DopamineDetox.ServiceAgent.Models.Responses;

namespace DopamineDetox.ServiceAgent.Interfaces
{
    public interface IResetService
    {
        Task<ApiResponse<bool>> ClearAllCache();
    }
}
