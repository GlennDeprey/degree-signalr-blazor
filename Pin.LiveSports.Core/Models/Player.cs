using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.LiveSports.Core.Models
{
    public class Player : BaseModel
    {
        public string PlayerName { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public Guid? RoleId { get; set; }
        public Role Role { get; set; }
        public Guid? TeamId { get; set; }
        public Team Team { get; set; }
    }
}
