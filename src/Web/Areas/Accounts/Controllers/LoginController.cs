using Microsoft.AspNetCore.Mvc;
using Spokesoft.Clobberfest.Web.Areas.Accounts.Models;

namespace Spokesoft.Clobberfest.Web.Areas.Accounts.Controllers
{
    [Area(AreaName)]
    public class LoginController : AccountsController
    {
        [Route(LoginRoute)]
        public IActionResult Get()
        {
            var viewModel = new LoginViewModel();
            return View(ViewPath("Login.cshtml"), viewModel);
        }
    }
}