using Microsoft.AspNetCore.Mvc;
using Spokesoft.Clobberfest.Web.Areas.Accounts.Models;

namespace Spokesoft.Clobberfest.Web.Areas.Accounts.Controllers
{
    [Area(AreaName)]
    public class LockoutController : AccountsController
    {
        [Route(LockoutRoute)]
        public IActionResult Get()
        {
            var viewModel = new LockoutViewModel();
            return View(ViewPath("Lockout.cshtml"), viewModel);
        }
    }
}