namespace Spokesoft.Clobberfest.Data.Models.Auth
{
    /// <summary>
    /// Role claim base entity
    /// </summary>
    public class BaseRoleClaim
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public long CreatedById { get; set; }
        public long UpdatedById { get; set; }
        public long? DeletedById { get; set; }
    }

    /// <summary>
    /// Role claim entity
    /// </summary>
    public class RoleClaim : BaseRoleClaim
    {
        public long Id { get; set; }

        public User CreatedBy { get; set; } = null!;
        public User UpdatedBy { get; set; } = null!;
        public User? DeletedBy { get; set; } = null!;
    }
}