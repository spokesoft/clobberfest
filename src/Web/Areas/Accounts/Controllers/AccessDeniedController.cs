using Microsoft.AspNetCore.Mvc;
using Spokesoft.Clobberfest.Web.Areas.Accounts.Models;

namespace Spokesoft.Clobberfest.Web.Areas.Accounts.Controllers
{
    [Area(AreaName)]
    public class AccessDeniedController : AccountsController
    {
        [Route(AccessDeniedRoute)]
        public IActionResult Get()
        {
            var viewModel = new AccessDeniedViewModel();
            return View(ViewPath("AccessDenied.cshtml"), viewModel);
        }
    }
}