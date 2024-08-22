using Microsoft.AspNetCore.Mvc;
using Spokesoft.Clobberfest.Web.Areas.Accounts.Models;

namespace Spokesoft.Clobberfest.Web.Areas.Accounts.Controllers
{
    [Area(AreaName)]
    public class RegisterConfirmationController : AccountsController
    {
        [Route(RegisterConfirmationRoute)]
        public IActionResult Get()
        {
            var viewModel = new RegisterConfirmationViewModel();
            return View(ViewPath("RegisterConfirmation.cshtml"), viewModel);
        }
    }
}