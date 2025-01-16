namespace DopamineDetox.ServiceAgent.Requests
{
    public class GetTopicsRequest
    {
        public int? Id { get; set; }
        public bool? IsActive { get; set; }
        public string? Term { get; set; }
        public string? UserId { get; set; }
    }
}
