using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerediaJ_API_DashboardAPI.Models
{
    public class StatsModel
    {
        public string? Total {get; set;}
       public List<string>? Facebook { get; set; }
        public List<string>? Twitter { get; set; }
        public List<string>? Instagram { get; set; }
        public List<string>? Youtube { get; set; }
    }
}