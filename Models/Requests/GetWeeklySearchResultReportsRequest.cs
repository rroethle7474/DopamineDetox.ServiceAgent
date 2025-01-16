namespace DopamineDetox.ServiceAgent.Requests
{
    public class GetWeeklySearchResultReportsRequest
    {
        public int? Id { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public bool? IsSuccess { get; set; }
    }
}
