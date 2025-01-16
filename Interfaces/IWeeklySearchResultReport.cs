using DopamineDetox.Domain.Dtos;
using DopamineDetox.ServiceAgent.Models.Responses;
using DopamineDetox.ServiceAgent.Requests;

namespace DopamineDetox.ServiceAgent.Interfaces
{
    public interface IWeeklySearchResultReportService
    {
        Task<ApiResponse<IEnumerable<WeeklySearchResultReportDto>>> GetWeeklySearchResultReportsAsync(GetWeeklySearchResultReportsRequest request, CancellationToken cancellationToken);
        Task<ApiResponse<WeeklySearchResultReportDto>> GetWeeklySearchResultReportAsync(int id, CancellationToken cancellationToken);
        Task<ApiResponse<WeeklySearchResultReportDto>> CreateWeeklySearchResultReportAsync(WeeklySearchResultReportDto weeklySearchResultReportDto, CancellationToken cancellationToken);
        Task<ApiResponse<WeeklySearchResultReportDto>> UpdateWeeklySearchResultReportAsync(int id, WeeklySearchResultReportDto weeklySearchResultReportDto, CancellationToken cancellationToken);
        Task<ApiResponse<bool>> DeleteWeeklySearchResultReportAsync(int id, CancellationToken cancellationToken);
        Task<ApiResponse<bool>> EmailUserWeeklyReport(string userId, CancellationToken cancellationToken);
    }
}
