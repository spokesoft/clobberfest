using Microsoft.AspNetCore.Mvc;
using Spokesoft.Clobberfest.Web.Areas.Accounts.Models;

namespace Spokesoft.Clobberfest.Web.Areas.Accounts.Controllers
{
    [Area(AreaName)]
    public class LogoutController : AccountsController
    {
        [Route(LogoutRoute)]
        public IActionResult Get()
        {
            var viewModel = new LogoutViewModel();
            return View(ViewPath("Logout.cshtml"), viewModel);
        }
    }
}