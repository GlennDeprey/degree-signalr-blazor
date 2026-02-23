namespace Pin.LiveSports.Blazor.ViewModels.Champions
{
    public class ChampionViewModel : BaseViewModel
    {
        public string Name { get; set; }
        public bool IsSelected { get; set; }
        public string ImageUrl => $"https://ddragon.leagueoflegends.com/cdn/img/champion/loading/{Name.Replace(" ", "")}_0.jpg";
        public string SmallImageUrl => $"https://ddragon.leagueoflegends.com/cdn/15.7.1/img/champion/{Name.Replace(" ", "")}.png";
    }
}
