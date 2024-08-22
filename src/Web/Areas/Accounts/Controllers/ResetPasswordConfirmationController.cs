using Microsoft.AspNetCore.Mvc;
using Spokesoft.Clobberfest.Web.Areas.Accounts.Models;

namespace Spokesoft.Clobberfest.Web.Areas.Accounts.Controllers
{
    [Area(AreaName)]
    public class ResetPasswordConfirmationController : AccountsController
    {
        [Route(ResetPasswordConfirmationRoute)]
        public IActionResult Get()
        {
            var viewModel = new ResetPasswordConfirmationViewModel();
            return View(ViewPath("ResetPasswordConfirmation.cshtml"), viewModel);
        }
    }
}