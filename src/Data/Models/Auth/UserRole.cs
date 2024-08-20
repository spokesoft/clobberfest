namespace Spokesoft.Clobberfest.Data.Models.Auth
{
    /// <summary>
    /// User role base entity
    /// </summary>
    public class BaseUserRole
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public long CreatedById { get; set; }
        public long UpdatedById { get; set; }
        public long? DeletedById { get; set; }
    }

    /// <summary>
    /// User role entity
    /// </summary>
    public class UserRole : BaseUserRole
    {
        public long Id { get; set; }

        public User CreatedBy { get; set; } = null!;
        public User UpdatedBy { get; set; } = null!;
        public User? DeletedBy { get; set; } = null!;
    }
}