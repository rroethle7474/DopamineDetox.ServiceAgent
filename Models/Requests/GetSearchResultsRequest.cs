namespace DopamineDetox.ServiceAgent.Requests
{
    public class GetSearchResultsRequest
    {
        public string? UserId { get; set; }
        public int? ContentTypeId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public bool IsHomePage { get; set; }
        public bool isMVPResults { get; set; }
    }
}
