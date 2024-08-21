using Spokesoft.Clobberfest.Data.Models.Auth;

namespace Spokesoft.Clobberfest.Data.Models.Auth
{
    /// <summary>
    /// User base entity
    /// </summary>
    public class BaseUser
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public long CreatedById { get; set; }
        public long UpdatedById { get; set; }
        public long? DeletedById { get; set; }
    }

    /// <summary>
    /// User entity
    /// </summary>
    public class User : BaseUser
    {
        public long Id { get; set; }

        public User CreatedBy { get; set; } = null!;
        public User UpdatedBy { get; set; } = null!;
        public User? DeletedBy { get; set; } = null!;
    }
}