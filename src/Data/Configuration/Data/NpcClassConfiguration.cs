using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spokesoft.Clobberfest.Data.Models.Data;

namespace Spokesoft.Clobberfest.Data.Configuration.Data
{
    /// <summary>
    /// Npc class entity type configuration
    /// </summary>
    public class NpcClassTypeConfiguration : IEntityTypeConfiguration<NpcClass>
    {
        public void Configure(EntityTypeBuilder<NpcClass> builder)
        {
            builder.ToTable("NpcClasses", "Data");
        }
    }
}
