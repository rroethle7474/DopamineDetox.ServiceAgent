using DopamineDetox.Domain.Enums;

namespace DopamineDetox.ServiceAgent.Requests
{
    public class SendEmailRequest
    {
        public string ToEmail { get; set; }
        public EmailTemplateType EmailTemplateType { get; set; }
        public List<DopamineDetox.Domain.Models.Token>? Tokens { get; set; }
    }
}