namespace DopamineDetox.ServiceAgent.Requests
{
    public class GetSubTopicsRequest
    {
        public string? UserId { get; set; }
        public bool? IsActive { get; set; }
        public string? Term { get; set; }
        public int? TopicId { get; set; }
        public bool? ExcludeFromTwitter { get; set; }
    }
}
