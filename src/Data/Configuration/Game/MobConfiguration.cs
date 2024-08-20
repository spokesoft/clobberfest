using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spokesoft.Clobberfest.Data.Models.Game;

namespace Spokesoft.Clobberfest.Data.Configuration.Game
{
    /// <summary>
    /// Mob entity type configuration
    /// </summary>
    public class MobTypeConfiguration : IEntityTypeConfiguration<Mob>
    {
        public void Configure(EntityTypeBuilder<Mob> builder)
        {
            builder.ToTable("Mobs", "Game");
        }
    }
}
