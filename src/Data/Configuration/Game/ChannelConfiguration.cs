using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spokesoft.Clobberfest.Data.Models.Game;

namespace Spokesoft.Clobberfest.Data.Configuration.Game
{
    /// <summary>
    /// Channel entity type configuration
    /// </summary>
    public class ChannelTypeConfiguration : IEntityTypeConfiguration<Channel>
    {
        public void Configure(EntityTypeBuilder<Channel> builder)
        {
            builder.ToTable("Channels", "Game");
        }
    }
}
