using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HerediaJ_API_DashboardAPI.Services;
using Microsoft.AspNetCore.Mvc;
using HerediaJ_API_DashboardAPI.Models;

namespace HerediaJ_API_DashboardAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SocialMediaController : ControllerBase
    {
        
        private readonly SocialMediaService _socialMediaService;

        public SocialMediaController(SocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        [HttpGet]
        [Route("stats")]
        public List<StatsModel> GetUserStats()
        {
            return _socialMediaService.GetUserStats();
        }

    }
}