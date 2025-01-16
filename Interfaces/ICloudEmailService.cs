using DopamineDetox.ServiceAgent.Models.Responses;
using DopamineDetox.ServiceAgent.Requests;

namespace DopamineDetox.ServiceAgent.Interfaces
{
    public interface ICloudEmailService
    {
        Task<ApiResponse<bool>> SendEmailAsync(SendEmailRequest request, CancellationToken cancellationToken);
        Task<ApiResponse<bool>> SendMVPUserWeeklyEmails(SendMVPEmailRequest request, CancellationToken cancellationToken);

    }
}
