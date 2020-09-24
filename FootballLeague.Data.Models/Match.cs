
namespace FootballLeague.Data.Models
{
    public class Match : BaseModel<int>
    {
        public Team TeamHost { get; set; }
        public Team TeamGuest { get; set; }
        public int HostScore { get; set; }
        public int GuestScore { get; set; }
    }
}
