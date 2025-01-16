using DopamineDetox.ServiceAgent.Interfaces;

namespace DopamineDetox.ServiceAgent.Configuration
{
    public class ServiceAgentConfig : IServiceAgentConfig
    {
        public string BaseUrl { get; set; } = "https://localhost:5154";
        public int TimeoutSeconds { get; set; } = 30;
        public int MaxRetryAttempts { get; set; } = 3;
        public int RetryDelayMilliseconds { get; set; } = 1000;
    }
}
