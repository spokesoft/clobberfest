using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spokesoft.Clobberfest.Data.Models.Data;

namespace Spokesoft.Clobberfest.Data.Configuration.Data
{
    /// <summary>
    /// Mob skill entity type configuration
    /// </summary>
    public class MobSkillTypeConfiguration : IEntityTypeConfiguration<MobSkill>
    {
        public void Configure(EntityTypeBuilder<MobSkill> builder)
        {
            builder.ToTable("MobSkills", "Data");
        }
    }
}
