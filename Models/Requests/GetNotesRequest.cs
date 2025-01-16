namespace DopamineDetox.ServiceAgent.Requests
{
    public class GetNotesRequest
    {
        public int? Id { get; set; }
        public string? UserId { get; set; }
        public bool? IsActive { get; set; }
        public int? SearchResultId { get; set; }
    }
}