using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Spokesoft.Clobberfest.Data.Configuration.Game
{
    /// <summary>
    /// Game entity type configuration
    /// </summary>
    public class GameTypeConfiguration : IEntityTypeConfiguration<Models.Game.Game>
    {
        public void Configure(EntityTypeBuilder<Models.Game.Game> builder)
        {
            builder.ToTable("Games", "Game");
        }
    }
}
