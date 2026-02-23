using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.LiveSports.Core.Models
{
    public class Match : BaseModel
    {
        public Guid? MatchTypeId { get; set; }
        public MatchType MatchType { get; set; }
        public Guid? BlueTeamId { get; set; }
        public Team BlueTeam { get; set; }
        public Guid? RedTeamId { get; set; }
        public Team RedTeam { get; set; }
        public int BlueTeamWins { get; set; }
        public int RedTeamWins { get; set; }
        public DateTime Created { get; set; }

    }
}
