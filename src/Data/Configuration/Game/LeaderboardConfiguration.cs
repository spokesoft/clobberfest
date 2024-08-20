using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spokesoft.Clobberfest.Data.Models.Game;

namespace Spokesoft.Clobberfest.Data.Configuration.Game
{
    /// <summary>
    /// Leaderboard entity type configuration
    /// </summary>
    public class LeaderboardTypeConfiguration : IEntityTypeConfiguration<Leaderboard>
    {
        public void Configure(EntityTypeBuilder<Leaderboard> builder)
        {
            builder.ToTable("Leaderboards", "Game");
        }
    }
}
