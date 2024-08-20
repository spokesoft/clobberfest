---
to: <%= h.toDataModelCsConfiguration(name, schema) %>
force: true
---
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spokesoft.Clobberfest.Data.Models.<%= h.toSchema(schema) %>;

namespace Spokesoft.Clobberfest.Data.Configuration.<%= h.toSchema(schema) %>
{
    /// <summary>
    /// <%= h.toTitle(name) %> entity type configuration
    /// </summary>
    public class <%= h.toModel(name) %>TypeConfiguration : IEntityTypeConfiguration<<%= h.toModel(name) %>>
    {
        public void Configure(EntityTypeBuilder<<%= h.toModel(name) %>> builder)
        {
            builder.ToTable("<%= h.toTable(name) %>", "<%= h.toSchema(schema) %>");
        }
    }
}
