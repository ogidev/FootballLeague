using System.ComponentModel.DataAnnotations;

namespace FootballLeague.Data.Models
{
    public class Team : BaseModel<int>
    {
        [Required(ErrorMessage ="Name of the team is required field")]
        public string Name { get; set; }
        public int Points { get; set; }
    }
}
