---
to: <%= h.toDataModelCsRepository(name, schema) %>
force: true
---
namespace Spokesoft.Clobberfest.Data.Repositories.<%= h.toSchema(schema) %>
{
    /// <summary>
    /// <%= h.toTitle(name) %> repository
    /// </summary>
    public class <%= h.toModel(name) %>Repository : Repository
    {
        // implementation here
    }
}
