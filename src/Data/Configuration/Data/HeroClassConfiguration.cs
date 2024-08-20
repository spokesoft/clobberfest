using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spokesoft.Clobberfest.Data.Models.Data;

namespace Spokesoft.Clobberfest.Data.Configuration.Data
{
    /// <summary>
    /// Hero class entity type configuration
    /// </summary>
    public class HeroClassTypeConfiguration : IEntityTypeConfiguration<HeroClass>
    {
        public void Configure(EntityTypeBuilder<HeroClass> builder)
        {
            builder.ToTable("HeroClasses", "Data");
        }
    }
}
