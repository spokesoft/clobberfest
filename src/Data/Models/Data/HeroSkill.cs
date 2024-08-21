using Spokesoft.Clobberfest.Data.Models.Auth;

namespace Spokesoft.Clobberfest.Data.Models.Data
{
    /// <summary>
    /// Hero skill base entity
    /// </summary>
    public class BaseHeroSkill
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public long CreatedById { get; set; }
        public long UpdatedById { get; set; }
        public long? DeletedById { get; set; }
    }

    /// <summary>
    /// Hero skill entity
    /// </summary>
    public class HeroSkill : BaseHeroSkill
    {
        public long Id { get; set; }

        public User CreatedBy { get; set; } = null!;
        public User UpdatedBy { get; set; } = null!;
        public User? DeletedBy { get; set; } = null!;
    }
}