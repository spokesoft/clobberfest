using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spokesoft.Clobberfest.Data.Models.Data;

namespace Spokesoft.Clobberfest.Data.Configuration.Data
{
    /// <summary>
    /// Item skill entity type configuration
    /// </summary>
    public class ItemSkillTypeConfiguration : IEntityTypeConfiguration<ItemSkill>
    {
        public void Configure(EntityTypeBuilder<ItemSkill> builder)
        {
            builder.ToTable("ItemSkills", "Data");
        }
    }
}
