---
to: <%= h.toWebPageController(name, area) %>
force: true
---
using Microsoft.AspNetCore.Mvc;
using Spokesoft.Clobberfest.Web.Areas.<%= area %>.Models;

namespace Spokesoft.Clobberfest.Web.Areas.<%= area %>.Controllers
{
    [Area(AreaName)]
    public class <%= name %>Controller : <%= area %>Controller
    {
        [Route(<%= name %>Route)]
        public IActionResult Get()
        {
            var viewModel = new <%= name %>ViewModel();
            return View(ViewPath("<%= name %>.cshtml"), viewModel);
        }
    }
}