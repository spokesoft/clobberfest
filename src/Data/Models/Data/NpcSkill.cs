namespace Spokesoft.Clobberfest.Data.Models.Data
{
    /// <summary>
    /// Npc skill base entity
    /// </summary>
    public class BaseNpcSkill
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public long CreatedById { get; set; }
        public long UpdatedById { get; set; }
        public long? DeletedById { get; set; }
    }

    /// <summary>
    /// Npc skill entity
    /// </summary>
    public class NpcSkill : BaseNpcSkill
    {
        public long Id { get; set; }

        public User CreatedBy { get; set; } = null!;
        public User UpdatedBy { get; set; } = null!;
        public User? DeletedBy { get; set; } = null!;
    }
}