namespace DopamineDetox.ServiceAgent.Requests
{
    public class GetSearchResultReportRequest
    {
        public int? Id { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public int? ContentTypeId { get; set; }
        public bool? IsSuccess { get; set; }
        public bool? IsDefaultReport { get; set; }
        public bool? IsChannelReport { get; set; }
    }
}
