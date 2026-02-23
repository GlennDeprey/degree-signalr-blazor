using Pin.LiveSports.Core.Models;
using Pin.LiveSports.Core.Services.Interfaces;

namespace Pin.LiveSports.Core.Services
{
    public class MapService : IMapService
    {
        private List<Tower> _towers;
        public MapService()
        {
            AddTowers();
        }

        private void AddTowers()
        {
            _towers = new List<Tower>
            {
                // Red Nexus
                new Tower { Name = "Red Top Nexus Tower", X = 83, Y = 11, Team = Types.TeamType.Red, AnyDependency = true, Dependencies = new List<string> { "Red Mid Inhib", "Red Bot Inhib", "Red Top Inhib" }  },
                new Tower { Name = "Red Bot Nexus Tower", X = 86, Y = 15, Team = Types.TeamType.Red, AnyDependency = true, Dependencies = new List<string> { "Red Mid Inhib", "Red Bot Inhib", "Red Top Inhib" } }, 
                new Tower { Name = "Red Nexus", X = 86.5, Y = 10, Team = Types.TeamType.Red, IsLastTower = true, Dependencies = new List<string> { "Red Top Nexus Tower", "Red Bot Nexus Tower" } },
                // Red Top
                new Tower { Name = "Red Top T1", X = 28, Y = 6, Team = Types.TeamType.Red, CanBeDestroyed = true },
                new Tower { Name = "Red Top T2", X = 52, Y = 9, Team = Types.TeamType.Red, Dependencies = new List<string> { "Red Top T1" } },
                new Tower { Name = "Red Top Inhib Tower", X = 68.5, Y = 7, Team = Types.TeamType.Red, Dependencies = new List<string> { "Red Top T2" } },
                new Tower { Name = "Red Top Inhib", X = 74, Y = 7, Team = Types.TeamType.Red, Dependencies = new List<string> { "Red Top Inhib Tower" } },
                // Red Mid
                new Tower { Name = "Red Mid T1", X = 58.5, Y = 41, Team = Types.TeamType.Red, CanBeDestroyed = true },
                new Tower { Name = "Red Mid T2", X = 64, Y = 31, Team = Types.TeamType.Red, Dependencies = new List<string> { "Red Mid T1" } },
                new Tower { Name = "Red Mid Inhib Tower", X = 72, Y = 23, Team = Types.TeamType.Red, Dependencies = new List<string> { "Red Mid T2" } },
                new Tower { Name = "Red Mid Inhib", X = 75.5, Y = 20.5, Team = Types.TeamType.Red, Dependencies = new List<string> { "Red Mid Inhib Tower" } },
                // Red Bot
                new Tower { Name = "Red Bot T1", X = 91, Y = 68, Team = Types.TeamType.Red, CanBeDestroyed = true },
                new Tower { Name = "Red Bot T2", X = 87.5, Y = 43, Team = Types.TeamType.Red, Dependencies = new List<string> { "Red Bot T1" } },
                new Tower { Name = "Red Bot Inhib Tower", X = 89.5, Y = 28, Team = Types.TeamType.Red, Dependencies = new List<string> { "Red Bot T2" } },
                new Tower { Name = "Red Bot Inhib", X = 89, Y = 22.5, Team = Types.TeamType.Red, Dependencies = new List<string> { "Red Bot Inhib Tower" } },
                // Blue Nexus
                new Tower { Name = "Blue Top Nexus Tower", X = 10.5, Y = 83, Team = Types.TeamType.Blue, AnyDependency = true, Dependencies = new List<string> { "Blue Mid Inhib", "Blue Bot Inhib", "Blue Top Inhib" }   },
                new Tower { Name = "Blue Bot Nexus Tower", X = 14, Y = 85, Team = Types.TeamType.Blue, AnyDependency = true, Dependencies = new List<string> { "Blue Mid Inhib", "Blue Bot Inhib", "Blue Top Inhib" } },
                new Tower { Name = "Blue Nexus", X = 9.5, Y = 86.5, Team = Types.TeamType.Blue, IsLastTower = true, Dependencies = new List<string> { "Blue Top Nexus Tower", "Blue Bot Nexus Tower" } },
                // Blue Bot
                new Tower { Name = "Blue Bot T1", X = 69, Y = 90.5, Team = Types.TeamType.Blue, CanBeDestroyed = true },
                new Tower { Name = "Blue Bot T2", X = 45.5, Y = 87.5, Team = Types.TeamType.Blue, Dependencies = new List<string> { "Blue Bot T1" } },
                new Tower { Name = "Blue Bot Inhib Tower", X = 28, Y = 89, Team = Types.TeamType.Blue, Dependencies = new List<string> { "Blue Bot T2" } },
                new Tower { Name = "Blue Bot Inhib", X = 22.5, Y = 89.5, Team = Types.TeamType.Blue, Dependencies = new List<string> { "Blue Bot Inhib Tower" } },
                // Blue Mid
                new Tower { Name = "Blue Mid T1", X = 38, Y = 55, Team = Types.TeamType.Blue, CanBeDestroyed = true },
                new Tower { Name = "Blue Mid T2", X = 32, Y = 66, Team = Types.TeamType.Blue, Dependencies = new List<string> { "Blue Mid T1" } },
                new Tower { Name = "Blue Mid Inhib Tower", X = 24, Y = 73, Team = Types.TeamType.Blue, Dependencies = new List<string> { "Blue Mid T2" } },
                new Tower { Name = "Blue Mid Inhib", X = 20.3, Y = 76.5, Team = Types.TeamType.Blue, Dependencies = new List<string> { "Blue Mid Inhib Tower" } },
                // Blue Top
                new Tower { Name = "Blue Top T1", X = 5.5, Y = 28.5, Team = Types.TeamType.Blue, CanBeDestroyed = true },
                new Tower { Name = "Blue Top T2", X = 9, Y = 53, Team = Types.TeamType.Blue, Dependencies = new List<string> { "Blue Top T1" } },
                new Tower { Name = "Blue Top Inhib Tower", X = 7, Team = Types.TeamType.Blue, Y = 69.5, Dependencies = new List<string> { "Blue Top T2" } },
                new Tower { Name = "Blue Top Inhib", X = 7, Y = 74, Team = Types.TeamType.Blue, Dependencies = new List<string> { "Blue Top Inhib Tower" } }
            };
        }

        public List<Tower> GetTowers()
        {
            return _towers;
        }
    }
}
