namespace DopamineDetox.ServiceAgent.Requests
{
    public class GetChannelsRequest
    {
        public string? UserId { get; set; }
        public bool? IsActive { get; set; }
        public string? ChannelName{ get; set; }
        public string? Identifier { get; set; }
        public string? Description { get; set; }
        public int? ContentTypeId { get; set; }

    }
}
