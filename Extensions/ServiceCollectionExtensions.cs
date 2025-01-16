using DopamineDetox.ServiceAgent.Configuration;
using DopamineDetox.ServiceAgent.Handlers;
using DopamineDetox.ServiceAgent.Interfaces;
using DopamineDetox.ServiceAgent.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace DopamineDetox.ServiceAgent.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDopamineDetoxServiceAgent(this IServiceCollection services, Action<ServiceAgentConfig> configureOptions)
        {
            services.Configure(configureOptions);
            services.AddSingleton<IServiceAgentConfig>(sp => sp.GetRequiredService<IOptions<ServiceAgentConfig>>().Value);

            services.AddTransient<RetryPolicyDelegatingHandler>();

            services.AddHttpClient<IApiService, ApiService>((sp, client) =>
            {
                var config = sp.GetRequiredService<IServiceAgentConfig>();
                var logger = sp.GetRequiredService<ILogger<IApiService>>();

                if (string.IsNullOrEmpty(config.BaseUrl))
                {
                    throw new InvalidOperationException("BaseUrl is not configured.");
                }

                try
                {
                    client.BaseAddress = new Uri(config.BaseUrl);
                }
                catch (UriFormatException ex)
                {
                    logger.LogError(ex, "Invalid BaseUrl: {BaseUrl}", config.BaseUrl);
                    throw;
                }

                client.Timeout = TimeSpan.FromSeconds(config.TimeoutSeconds);
            })
            .AddHttpMessageHandler<RetryPolicyDelegatingHandler>();

            services.AddScoped<IChannelService, ChannelService>();
            services.AddScoped<IContentTypeService, ContentTypeService>();
            services.AddScoped<IHistorySearchResultService, HistorySearchResultService>();
            services.AddScoped<INoteService, NoteService>();
            services.AddScoped<ISearchResultService, SearchResultService>();
            services.AddScoped<ISearchResultReportService, SearchResultReportService>();
            services.AddScoped<ISubTopicService, SubTopicService>();
            services.AddScoped<ITopicService, TopicService>();
            services.AddScoped<ITopSearchResultService, TopSearchResultService>();
            services.AddScoped<IWeeklySearchResultReportService, WeeklySearchResultReportService>();
            services.AddScoped<IResetService, ResetService>();
            services.AddScoped<IDefaultTopicService, DefaultTopicService>();
            services.AddScoped<ILoggingService, LoggingService>();
            services.AddScoped<ICloudEmailService, CloudEmailService>();
            services.AddScoped<IQuoteService, QuoteService>();

            return services;
        }
    }
}