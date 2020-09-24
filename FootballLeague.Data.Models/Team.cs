namespace FootballLeague.Data.Models
{
    public class Team : BaseModel<int>
    {
        public string Name { get; set; }
        public int Score { get; set; }
    }
}
