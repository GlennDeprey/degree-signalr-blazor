namespace Pin.LiveSports.Core.Models.RequestModel
{
    public class CreateMatchRequestModel
    {
        public Guid MatchTypeId { get; set; }
        public Guid BlueTeamId { get; set; }
        public Guid RedTeamId { get; set; }
        public int BlueTeamWins { get; set; }
        public int RedTeamWins { get; set; }
        public DateTime Created { get; set; }
    }
}
