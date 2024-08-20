using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spokesoft.Clobberfest.Data.Models.Data;

namespace Spokesoft.Clobberfest.Data.Configuration.Data
{
    /// <summary>
    /// Profession entity type configuration
    /// </summary>
    public class ProfessionTypeConfiguration : IEntityTypeConfiguration<Profession>
    {
        public void Configure(EntityTypeBuilder<Profession> builder)
        {
            builder.ToTable("Professions", "Data");
        }
    }
}
