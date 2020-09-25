using FootballLeague.Data.Models;
using System.Collections;
using System.Collections.Generic;

namespace FootballLeague.Services
{
    public interface IFootballLeagueService
    {
        IEnumerable<Team> GetTeamsRanking();
    }
}