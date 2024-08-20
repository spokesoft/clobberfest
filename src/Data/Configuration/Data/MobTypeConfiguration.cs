using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spokesoft.Clobberfest.Data.Models.Data;

namespace Spokesoft.Clobberfest.Data.Configuration.Data
{
    /// <summary>
    /// Mob type entity type configuration
    /// </summary>
    public class MobTypeTypeConfiguration : IEntityTypeConfiguration<MobType>
    {
        public void Configure(EntityTypeBuilder<MobType> builder)
        {
            builder.ToTable("MobTypes", "Data");
        }
    }
}
