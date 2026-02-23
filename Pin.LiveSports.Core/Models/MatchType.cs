using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.LiveSports.Core.Models
{
    public class MatchType : BaseModel
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public int RequiredWins { get; set; }
    }
}
