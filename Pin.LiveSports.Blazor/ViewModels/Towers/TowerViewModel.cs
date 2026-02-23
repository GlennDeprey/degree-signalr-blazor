using Pin.LiveSports.Core.Types;

namespace Pin.LiveSports.Blazor.ViewModels.Towers
{
    public class TowerViewModel
    {
        public TeamType Team { get; set; }
        public string Name { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public List<string> Dependencies { get; set; } = new List<string>();
        public bool IsDestroyed { get; set; }
        public bool CanBeDestroyed { get; set; }
        public bool AnyDependency { get; set; }
        public bool IsLastTower { get; set; }
    }
}
