using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spokesoft.Clobberfest.Data.Models.Data;

namespace Spokesoft.Clobberfest.Data.Configuration.Data
{
    /// <summary>
    /// Achievment entity type configuration
    /// </summary>
    public class AchievmentTypeConfiguration : IEntityTypeConfiguration<Achievment>
    {
        public void Configure(EntityTypeBuilder<Achievment> builder)
        {
            builder.ToTable("Achievments", "Data");
        }
    }
}
