---
to: <%= h.toWebPageModel(name, area) %>
force: true
---
namespace Spokesoft.Clobberfest.Web.Areas.<%= area %>.Models
{
    public class <%= name %>ViewModel : <%= area %>ViewModel
    {
        
    }
}