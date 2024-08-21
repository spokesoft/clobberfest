using Spokesoft.Clobberfest.Data.Models.Auth;

namespace Spokesoft.Clobberfest.Data.Models.Game
{
    /// <summary>
    /// Channel base entity
    /// </summary>
    public class BaseChannel
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public long CreatedById { get; set; }
        public long UpdatedById { get; set; }
        public long? DeletedById { get; set; }
    }

    /// <summary>
    /// Channel entity
    /// </summary>
    public class Channel : BaseChannel
    {
        public long Id { get; set; }

        public User CreatedBy { get; set; } = null!;
        public User UpdatedBy { get; set; } = null!;
        public User? DeletedBy { get; set; } = null!;
    }
}