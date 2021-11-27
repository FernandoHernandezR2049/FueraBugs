namespace FueraBugsDataManager.Models.Request
{
    public class TicketRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public int Status { get; set; }

    }
}
