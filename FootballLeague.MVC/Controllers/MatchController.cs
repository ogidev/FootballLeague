using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballLeague.Data.Models;
using FootballLeague.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FootballLeague.MVC.Controllers
{
    public class MatchController : Controller
    {
        public IFootballLeagueService FootballLeagueService { get; }

        public MatchController(IFootballLeagueService footballLeagueService)
        {
            FootballLeagueService = footballLeagueService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IAsyncResult Create()
        {

        }

        [Authorize]
        [HttpPost]
        public IActionResult Create(Match input)
        {
            FootballLeagueService.AddNewMatch(input);
            return RedirectToAction("View", "Home");
        }

        [Authorize]
        [HttpPost]
        public IActionResult Modify(Match input)
        {
            FootballLeagueService.ModifyMatch(input);
            return RedirectToAction("View", "Home");
        }

        [Authorize]
        [HttpPost]
        public IActionResult Delete(int id)
        {
            FootballLeagueService.DeleteMatch(id);
            return RedirectToAction("View", "Home");

        }
    }

}
