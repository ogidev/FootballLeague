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
        private readonly IRepository<Match> matchesRepository;

        public FootballLeagueService(IRepository<Team> teamsRepository, IRepository<Match> matchesRepository)
        {
            this.teamsRepository = teamsRepository;
            this.matchesRepository = matchesRepository;
        }

        public void AddNewMatch()
        {
            throw new NotImplementedException();
        }

        public void AddNewTeam()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Match> GetPlayedMatches()
        {
            return matchesRepository.All().OrderByDescending(m=>m.id).ToList();
        }

        public IEnumerable<Team> GetTeamsRanking()
        {           
            return teamsRepository.All().OrderByDescending(s => s.Points).ToList();
        }
    }
}
