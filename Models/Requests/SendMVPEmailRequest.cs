using DopamineDetox.Domain.Enums;

namespace DopamineDetox.ServiceAgent.Requests
{
    public class SendMVPEmailRequest
    {
        public List<string> UserIds { get; set; } = new List<string>();
    }
}