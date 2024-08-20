namespace Spokesoft.Clobberfest.Data.Models.Data
{
    /// <summary>
    /// Item skill interface
    /// </summary>
    public interface IItemSkill
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