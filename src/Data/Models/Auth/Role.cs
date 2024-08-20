namespace Spokesoft.Data.Models.Auth
{
    /// <summary>
    /// Role base entity
    /// </summary>
    public class BaseRole
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public long CreatedById { get; set; }
        public long UpdatedById { get; set; }
        public long? DeletedById { get; set; }
    }

    /// <summary>
    /// Role entity
    /// </summary>
    public class Role : BaseRole
    {
        public long Id { get; set; }
    }
}