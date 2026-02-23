using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.LiveSports.Core.Models
{
    public class Team : BaseModel
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string ImageUrl { get; set; }
        public string SmallImageUrl { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public ICollection<Player> Players { get; set; }
    }
}
