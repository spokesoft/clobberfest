namespace Spokesoft.Clobberfest.Data.Models.Data
{
    /// <summary>
    /// Hero class interface
    /// </summary>
    public interface IHeroClass
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