using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spokesoft.Clobberfest.Data.Models.Auth;

namespace Spokesoft.Clobberfest.Data.Configuration.Auth
{
    /// <summary>
    /// Role entity type configuration
    /// </summary>
    public class RoleTypeConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Roles", "Auth");
        }
    }
}

