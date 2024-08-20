using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spokesoft.Clobberfest.Data.Models.Game;

namespace Spokesoft.Clobberfest.Data.Configuration.Game
{
    /// <summary>
    /// Npc entity type configuration
    /// </summary>
    public class NpcTypeConfiguration : IEntityTypeConfiguration<Npc>
    {
        public void Configure(EntityTypeBuilder<Npc> builder)
        {
            builder.ToTable("Npcs", "Game");
        }
    }
}
