using Pin.LiveSports.Blazor.ViewModels.Teams;

namespace Pin.LiveSports.Blazor.ViewModels.Matches
{
    public class MatchIndexViewModel
    {
        public MatchTypeViewModel MatchType { get; set; }
        public TeamDetailViewModel BlueTeam { get; set; }
        public TeamDetailViewModel RedTeam { get; set; }
        public int BlueTeamWins { get; set; }
        public int RedTeamWins { get; set; }
        public DateTime Created { get; set; }

    }
}
