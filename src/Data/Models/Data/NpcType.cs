namespace Spokesoft.Clobberfest.Data.Models.Data
{
    /// <summary>
    /// Npc type base entity
    /// </summary>
    public class BaseNpcType
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public long CreatedById { get; set; }
        public long UpdatedById { get; set; }
        public long? DeletedById { get; set; }
    }

    /// <summary>
    /// Npc type entity
    /// </summary>
    public class NpcType : BaseNpcType
    {
        public long Id { get; set; }

        public User CreatedBy { get; set; } = null!;
        public User UpdatedBy { get; set; } = null!;
        public User? DeletedBy { get; set; } = null!;
    }
}