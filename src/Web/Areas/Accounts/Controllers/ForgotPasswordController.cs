using Microsoft.AspNetCore.Mvc;
using Spokesoft.Clobberfest.Web.Areas.Accounts.Models;

namespace Spokesoft.Clobberfest.Web.Areas.Accounts.Controllers
{
    [Area(AreaName)]
    public class ForgotPasswordController : AccountsController
    {
        [Route(ForgotPasswordRoute)]
        public IActionResult Get()
        {
            var viewModel = new ForgotPasswordViewModel();
            return View(ViewPath("ForgotPassword.cshtml"), viewModel);
        }
    }
}