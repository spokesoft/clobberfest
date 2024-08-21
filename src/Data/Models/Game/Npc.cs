using Spokesoft.Clobberfest.Data.Models.Auth;

namespace Spokesoft.Clobberfest.Data.Models.Game
{
    /// <summary>
    /// Npc base entity
    /// </summary>
    public class BaseNpc
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public long CreatedById { get; set; }
        public long UpdatedById { get; set; }
        public long? DeletedById { get; set; }
    }

    /// <summary>
    /// Npc entity
    /// </summary>
    public class Npc : BaseNpc
    {
        public long Id { get; set; }

        public User CreatedBy { get; set; } = null!;
        public User UpdatedBy { get; set; } = null!;
        public User? DeletedBy { get; set; } = null!;
    }
}