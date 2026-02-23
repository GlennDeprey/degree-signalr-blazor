namespace Pin.LiveSports.Blazor.ViewModels.Teams
{
    public class TeamViewModel : BaseViewModel
    {
        public int Rank { get; set; }
        public double WinRate { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string ImageUrl { get; set; }
        public string SmallImageUrl { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
    }
}
