namespace Spokesoft.Clobberfest.Data.Models.Auth
{
    /// <summary>
    /// User claim interface
    /// </summary>
    public interface IUserClaim
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public long CreatedById { get; set; }
        public long UpdatedById { get; set; }
        public long? DeletedById { get; set; }
    }
}