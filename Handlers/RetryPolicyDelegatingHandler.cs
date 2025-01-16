using DopamineDetox.ServiceAgent.Interfaces;

namespace DopamineDetox.ServiceAgent.Handlers
{
    public class RetryPolicyDelegatingHandler : DelegatingHandler
    {
        private readonly IServiceAgentConfig _config;

        public RetryPolicyDelegatingHandler(IServiceAgentConfig config)
        {
            _config = config;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            HttpResponseMessage response = null;
            for (int i = 0; i < _config.MaxRetryAttempts; i++)
            {
                response = await base.SendAsync(request, cancellationToken);

                if (response.IsSuccessStatusCode)
                {
                    return response;
                }

                await Task.Delay(_config.RetryDelayMilliseconds, cancellationToken);
            }

            return response;
        }
    }
}
