using Microsoft.AspNetCore.Mvc;
using Spokesoft.Clobberfest.Web.Areas.Accounts.Models;

namespace Spokesoft.Clobberfest.Web.Areas.Accounts.Controllers
{
    [Area(AreaName)]
    public class RegisterController : AccountsController
    {
        [Route(RegisterRoute)]
        public IActionResult Get()
        {
            var viewModel = new RegisterViewModel();
            return View(ViewPath("Register.cshtml"), viewModel);
        }
    }
}