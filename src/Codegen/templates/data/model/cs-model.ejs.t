---
to: <%= h.toDataModelCsModel(name, schema) %>
force: true
---
namespace Spokesoft.Clobberfest.Data.Models.<%= h.toSchema(schema) %>
{
    /// <summary>
    /// <%= h.toTitle(name) %> base entity
    /// </summary>
    public class Base<%= h.toModel(name) %>
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public long CreatedById { get; set; }
        public long UpdatedById { get; set; }
        public long? DeletedById { get; set; }
    }

    /// <summary>
    /// <%= h.toTitle(name) %> entity
    /// </summary>
    public class <%= h.toModel(name) %> : Base<%= h.toModel(name) %>
    {
        public long Id { get; set; }

        public User CreatedBy { get; set; } = null!;
        public User UpdatedBy { get; set; } = null!;
        public User? DeletedBy { get; set; } = null!;
    }
}