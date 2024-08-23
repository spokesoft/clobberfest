using Microsoft.AspNetCore.Mvc;
using Spokesoft.Clobberfest.Web.Areas.Accounts.Models;

namespace Spokesoft.Clobberfest.Web.Areas.Accounts.Controllers
{
    [Area(AreaName)]
    public class LoginWithRecoveryCodeController : AccountsController
    {
        [Route(LoginWithRecoveryCodeRoute)]
        public IActionResult Get()
        {
            var viewModel = new LoginWithRecoveryCodeViewModel();
            return View(ViewPath("LoginWithRecoveryCode.cshtml"), viewModel);
        }
    }
}