namespace DopamineDetox.ServiceAgent.Interfaces
{
    public interface IServiceAgentConfig
    {
        string BaseUrl { get; set; }
        int TimeoutSeconds { get; set; }
        int MaxRetryAttempts { get; set; }
        int RetryDelayMilliseconds { get; set; }
    }
}
