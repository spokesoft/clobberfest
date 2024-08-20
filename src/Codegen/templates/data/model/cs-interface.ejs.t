---
to: <%= h.toDataModelCsInterface(name, schema) %>
force: true
---
namespace Spokesoft.Clobberfest.Data.Models.<%= h.toSchema(schema) %>
{
    /// <summary>
    /// <%= h.toTitle(name) %> interface
    /// </summary>
    public interface I<%= h.toModel(name) %>
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