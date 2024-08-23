using Microsoft.AspNetCore.Mvc;
using Spokesoft.Clobberfest.Web.Areas.Accounts.Models;

namespace Spokesoft.Clobberfest.Web.Areas.Accounts.Controllers
{
    [Area(AreaName)]
    public class ConfirmEmailChangeController : AccountsController
    {
        [Route(ConfirmEmailChangeRoute)]
        public IActionResult Get()
        {
            var viewModel = new ConfirmEmailChangeViewModel();
            return View(ViewPath("ConfirmEmailChange.cshtml"), viewModel);
        }
    }
}