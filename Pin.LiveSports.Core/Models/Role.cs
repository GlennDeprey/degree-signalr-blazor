using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.LiveSports.Core.Models
{
    public class Role : BaseModel
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public int Order { get; set; }
    }
}
