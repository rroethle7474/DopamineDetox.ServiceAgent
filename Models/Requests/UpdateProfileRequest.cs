namespace DopamineDetox.ServiceAgent.Requests
{
    public class UpdateProfileRequest
    {
        public string? UserId { get; set; }
        public string? UserName { get; set; }
        public string? NewUserName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public bool IsAdmin { get; set; }
    }
}
