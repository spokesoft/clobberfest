using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spokesoft.Clobberfest.Data.Models.Data;

namespace Spokesoft.Clobberfest.Data.Configuration.Data
{
    /// <summary>
    /// Npc type entity type configuration
    /// </summary>
    public class NpcTypeTypeConfiguration : IEntityTypeConfiguration<NpcType>
    {
        public void Configure(EntityTypeBuilder<NpcType> builder)
        {
            builder.ToTable("NpcTypes", "Data");
        }
    }
}
