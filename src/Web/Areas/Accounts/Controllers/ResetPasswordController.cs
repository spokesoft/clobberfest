using Microsoft.AspNetCore.Mvc;
using Spokesoft.Clobberfest.Web.Areas.Accounts.Models;

namespace Spokesoft.Clobberfest.Web.Areas.Accounts.Controllers
{
    [Area(AreaName)]
    public class ResetPasswordController : AccountsController
    {
        [Route(ResetPasswordRoute)]
        public IActionResult Get()
        {
            var viewModel = new ResetPasswordViewModel();
            return View(ViewPath("ResetPassword.cshtml"), viewModel);
        }
    }
}