namespace DopamineDetox.ServiceAgent.Requests
{
    public class ChangePasswordRequest
    {
        public string? UserId { get; set; }
        public string? UserName { get; set; }
        public string? OldPassword { get; set; }
        public string? NewPassword { get; set; }
    }
}
