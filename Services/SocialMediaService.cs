using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HerediaJ_API_DashboardAPI.Models;
using Microsoft.AspNetCore.Identity.Data;

namespace HerediaJ_API_DashboardAPI.Services
{
    public class SocialMediaService
    {
    


        public List<StatsModel> StatList = new ();

        public List<StatsModel> GetUserStats()
        {

         StatsModel thing = new StatsModel();   

            thing.Total = "23,004";
            thing.Facebook = new List<string> { "1987", "87", "52", "12 Today", "3%", "2%" };
            thing.Instagram = new List<string> { "11k", "5462", "52k", "1099 Today", "2257%", "1375%" };
            thing.Twitter = new List<string> {"1044", "117", "507", "99 Today", "303%", "553%"};
            thing.Youtube = new List<string> {"8239", "107", "1407", "144 Today", "19%", "12%"};
            
        StatList.Add(thing);
        return StatList;

        }


    }
}