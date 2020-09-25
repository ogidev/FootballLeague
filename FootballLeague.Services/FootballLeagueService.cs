using FootballLeague.Data.Models;
using FootballLeague.Data.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballLeague.Services
{
    public class FootballLeagueService : IFootballLeagueService
    {
        private readonly IRepository<Team> teamsRepository;

        public FootballLeagueService(IRepository<Team> teamsRepository)
        {
            this.teamsRepository = teamsRepository;
        }
        public IEnumerable<Team> GetTeamsRanking()
        {           
            return teamsRepository.All().OrderByDescending(s => s.Score).ToList();
        }
    }
}
