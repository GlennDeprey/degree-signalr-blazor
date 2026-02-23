using Pin.LiveSports.Blazor.ViewModels.Champions;
using Pin.LiveSports.Blazor.ViewModels.Matches;

namespace Pin.LiveSports.Blazor.ViewModels.Teams
{
    public class TeamMatchViewModel : TeamDetailViewModel
    {
        public ChampionViewModel[] Bans { get; set; } = new ChampionViewModel[5];
        public ChampionViewModel[] Champions { get; set; } = new ChampionViewModel[5];
        public MatchScoreViewModel[] PlayerScores { get; set; } = new MatchScoreViewModel[5];
        public int MatchWins { get; set; }

        public TeamMatchViewModel()
        {
            InitializeScores();
        }

        public void InitializeScores()
        {
            PlayerScores = new[]
            {
                new MatchScoreViewModel(),
                new MatchScoreViewModel(),
                new MatchScoreViewModel(),
                new MatchScoreViewModel(),
                new MatchScoreViewModel()
            };
        }
    }
}
