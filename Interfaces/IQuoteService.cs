using DopamineDetox.Domain.Dtos;
using DopamineDetox.ServiceAgent.Models.Responses;

namespace DopamineDetox.ServiceAgent.Interfaces
{
    public interface IQuoteService
    {
        Task<ApiResponse<QuoteDto>> GetDailyQuote(CancellationToken cancellationToken);
        Task<ApiResponse<bool>> CreateDailyQuote(CancellationToken cancellationToken);
        Task<ApiResponse<bool>> CreateDailyLearnMoreDetails(CancellationToken cancellationToken);
        Task<ApiResponse<LearnMoreDetailDto>> GetDailyLearnMoreDetails(CancellationToken cancellationToken);

    }
}
