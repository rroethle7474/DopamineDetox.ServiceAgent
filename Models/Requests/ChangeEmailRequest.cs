namespace DopamineDetox.ServiceAgent.Requests
{
    public class ChangeEmailRequest
    {
        public string? UserId { get; set; }
        public string? UserName { get; set; }
        public string? OldEmail { get; set; }
        public string? NewEmail { get; set; }
    }
}
