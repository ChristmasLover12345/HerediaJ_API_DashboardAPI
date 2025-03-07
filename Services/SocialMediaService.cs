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
            thing.Facebook = [];
            

        }


    }
}