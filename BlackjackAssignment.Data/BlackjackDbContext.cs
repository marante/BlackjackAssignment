using BlackjackAssignment.Data.Dtos;
using System.Data.Entity;

namespace BlackjackAssignment.Data
{
    public class BlackjackDbContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Leaderboard> Leaderboard { get; set; }
    }
}
