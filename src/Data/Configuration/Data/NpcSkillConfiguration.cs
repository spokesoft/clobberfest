using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spokesoft.Clobberfest.Data.Models.Data;

namespace Spokesoft.Clobberfest.Data.Configuration.Data
{
    /// <summary>
    /// Npc skill entity type configuration
    /// </summary>
    public class NpcSkillTypeConfiguration : IEntityTypeConfiguration<NpcSkill>
    {
        public void Configure(EntityTypeBuilder<NpcSkill> builder)
        {
            builder.ToTable("NpcSkills", "Data");
        }
    }
}
