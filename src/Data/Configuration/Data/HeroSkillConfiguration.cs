using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spokesoft.Clobberfest.Data.Models.Data;

namespace Spokesoft.Clobberfest.Data.Configuration.Data
{
    /// <summary>
    /// Hero skill entity type configuration
    /// </summary>
    public class HeroSkillTypeConfiguration : IEntityTypeConfiguration<HeroSkill>
    {
        public void Configure(EntityTypeBuilder<HeroSkill> builder)
        {
            builder.ToTable("HeroSkills", "Data");
        }
    }
}
