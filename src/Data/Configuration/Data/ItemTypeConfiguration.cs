using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spokesoft.Clobberfest.Data.Models.Data;

namespace Spokesoft.Clobberfest.Data.Configuration.Data
{
    /// <summary>
    /// Item type entity type configuration
    /// </summary>
    public class ItemTypeTypeConfiguration : IEntityTypeConfiguration<ItemType>
    {
        public void Configure(EntityTypeBuilder<ItemType> builder)
        {
            builder.ToTable("ItemTypes", "Data");
        }
    }
}
