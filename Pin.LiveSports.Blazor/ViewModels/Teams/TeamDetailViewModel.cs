using Pin.LiveSports.Blazor.ViewModels.Players;

namespace Pin.LiveSports.Blazor.ViewModels.Teams
{
    public class TeamDetailViewModel : TeamViewModel
    {
        public IList<PlayerViewModel> Players { get; set; } = new List<PlayerViewModel>();
    }
}
