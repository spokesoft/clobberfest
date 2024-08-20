using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spokesoft.Clobberfest.Data.Models.Data;

namespace Spokesoft.Clobberfest.Data.Configuration.Data
{
    /// <summary>
    /// Mob class entity type configuration
    /// </summary>
    public class MobClassTypeConfiguration : IEntityTypeConfiguration<MobClass>
    {
        public void Configure(EntityTypeBuilder<MobClass> builder)
        {
            builder.ToTable("MobClasses", "Data");
        }
    }
}
