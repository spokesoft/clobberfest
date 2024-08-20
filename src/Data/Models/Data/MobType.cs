namespace Spokesoft.Clobberfest.Data.Models.Data
{
    /// <summary>
    /// Mob type base entity
    /// </summary>
    public class BaseMobType
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public long CreatedById { get; set; }
        public long UpdatedById { get; set; }
        public long? DeletedById { get; set; }
    }

    /// <summary>
    /// Mob type entity
    /// </summary>
    public class MobType : BaseMobType
    {
        public long Id { get; set; }

        public User CreatedBy { get; set; } = null!;
        public User UpdatedBy { get; set; } = null!;
        public User? DeletedBy { get; set; } = null!;
    }
}