namespace Spokesoft.Clobberfest.Data.Models.Data
{
    /// <summary>
    /// Achievment base entity
    /// </summary>
    public class BaseAchievment
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public long CreatedById { get; set; }
        public long UpdatedById { get; set; }
        public long? DeletedById { get; set; }
    }

    /// <summary>
    /// Achievment entity
    /// </summary>
    public class Achievment : BaseAchievment
    {
        public long Id { get; set; }

        public User CreatedBy { get; set; } = null!;
        public User UpdatedBy { get; set; } = null!;
        public User? DeletedBy { get; set; } = null!;
    }
}