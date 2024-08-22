using Microsoft.AspNetCore.Mvc;
using Spokesoft.Clobberfest.Web.Areas.Accounts.Models;

namespace Spokesoft.Clobberfest.Web.Areas.Accounts.Controllers
{
    [Area(AreaName)]
    public class ResendEmailConfirmationController : AccountsController
    {
        [Route(ResendEmailConfirmationRoute)]
        public IActionResult Get()
        {
            var viewModel = new ResendEmailConfirmationViewModel();
            return View(ViewPath("ResendEmailConfirmation.cshtml"), viewModel);
        }
    }
}