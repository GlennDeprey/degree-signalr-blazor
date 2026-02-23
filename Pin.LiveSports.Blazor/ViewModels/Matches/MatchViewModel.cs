using Pin.LiveSports.Core.Types;
using Pin.LiveSports.Blazor.ViewModels.Champions;
using Pin.LiveSports.Blazor.ViewModels.Teams;
using Pin.LiveSports.Blazor.ViewModels.Towers;

namespace Pin.LiveSports.Blazor.ViewModels.Matches
{
    public class MatchViewModel : BaseViewModel
    {
        public MatchState State { get; set; } = MatchState.None;
        public MatchTypeViewModel MatchType { get; set; }
        public TeamMatchViewModel BlueTeam { get; set; }
        public TeamMatchViewModel RedTeam { get; set; }
        public IList<CrossViewModel> TowersDestroyed { get; set; } = new List<CrossViewModel>();
        public TeamType WinningTeam { get; set; } = TeamType.None;
        public DateTime Created { get; set; }
    }
}
