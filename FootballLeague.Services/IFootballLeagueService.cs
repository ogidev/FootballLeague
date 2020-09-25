using FootballLeague.Data.Models;
using System.Collections;
using System.Collections.Generic;

namespace FootballLeague.Services
{
    public interface IFootballLeagueService
    {
        IEnumerable<Match> GetPlayedMatches();
        IEnumerable<Team> GetTeamsRanking();
        void AddNewTeam(Team team);
        void AddNewMatch(Match match);
        void DeleteMatch(int id);
        void DeleteTeam(int id);
        void ModifyMatch(Match match);
        void ModifyTeam(Team team);
    }
}