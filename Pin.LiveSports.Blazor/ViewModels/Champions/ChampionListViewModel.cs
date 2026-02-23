using Pin.LiveSports.Blazor.ViewModels.Teams;

namespace Pin.LiveSports.Blazor.ViewModels.Champions
{
    public class ChampionListViewModel
    {
        public IList<ChampionViewModel> List { get; set; } = new List<ChampionViewModel>();
    }
}
