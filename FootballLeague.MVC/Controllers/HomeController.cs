﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FootballLeague.MVC.Models;
using FootballLeague.Services;

namespace FootballLeague.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFootballLeagueService footballLeagueService;

        public HomeController(IFootballLeagueService footballLeagueService)
        {
                this.footballLeagueService = footballLeagueService;
        }
        public IActionResult Index()
        {
            var ranking = this.footballLeagueService.GetTeamsRanking();
            return View(ranking);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
