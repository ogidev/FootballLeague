
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FootballLeague.Data.Models
{
    public class Match : BaseModel<int>
    {
        [Required]
        [DisplayName("Host team")]
        public Team TeamHost { get; set; }
        [Required]
        [DisplayName("Guest team")]
        public Team TeamGuest { get; set; }
        [Required]
        [Range(0,20)]
        public int HostScore { get; set; }
        [Required]
        [Range(0, 20)]
        public int GuestScore { get; set; }
    }
}
