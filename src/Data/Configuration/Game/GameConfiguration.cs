using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spokesoft.Clobberfest.Data.Models.Game;

namespace Spokesoft.Clobberfest.Data.Configuration.Game
{
    /// <summary>
    /// Game entity type configuration
    /// </summary>
    public class GameTypeConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.ToTable("Games", "Game");
        }
    }
}
