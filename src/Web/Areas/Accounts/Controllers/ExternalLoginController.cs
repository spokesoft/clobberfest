using Microsoft.AspNetCore.Mvc;
using Spokesoft.Clobberfest.Web.Areas.Accounts.Models;

namespace Spokesoft.Clobberfest.Web.Areas.Accounts.Controllers
{
    [Area(AreaName)]
    public class ExternalLoginController : AccountsController
    {
        [Route(ExternalLoginRoute)]
        public IActionResult Get()
        {
            var viewModel = new ExternalLoginViewModel();
            return View(ViewPath("ExternalLogin.cshtml"), viewModel);
        }
    }
}