using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballLeague.Services;
using Microsoft.AspNetCore.Mvc;

namespace FootballLeague.MVC.Controllers
{
    public class TeamController : Controller
    {
        public TeamController(IFootballLeagueService footballLeagueService)
        {
            FootballLeagueService = footballLeagueService;
        }

        public IFootballLeagueService FootballLeagueService { get; }

        public IActionResult Index()
        {
            return View();
        }
    }
}
