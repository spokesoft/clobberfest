using Microsoft.AspNetCore.Mvc;
using Spokesoft.Clobberfest.Web.Areas.Accounts.Models;

namespace Spokesoft.Clobberfest.Web.Areas.Accounts.Controllers
{
    [Area(AreaName)]
    public class LoginWith2faController : AccountsController
    {
        [Route(LoginWith2faRoute)]
        public IActionResult Get()
        {
            var viewModel = new LoginWith2faViewModel();
            return View(ViewPath("LoginWith2fa.cshtml"), viewModel);
        }
    }
}