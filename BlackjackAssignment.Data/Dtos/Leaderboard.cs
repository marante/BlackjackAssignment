using System.Collections.Generic;

namespace BlackjackAssignment.Data.Dtos
{
    public class Leaderboard
    {
        public int Id { get; set; }
        public virtual IEnumerable<Player> Players { get; set; }
    }
}
