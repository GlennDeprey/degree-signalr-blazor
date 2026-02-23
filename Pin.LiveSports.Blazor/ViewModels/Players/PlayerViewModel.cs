namespace Pin.LiveSports.Blazor.ViewModels.Players
{
    public class PlayerViewModel : BaseViewModel
    {
        public string PlayerName { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public RoleViewModel Role { get; set; }
    }
}
