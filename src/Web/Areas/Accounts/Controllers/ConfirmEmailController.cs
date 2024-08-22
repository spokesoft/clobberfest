using Microsoft.AspNetCore.Mvc;
using Spokesoft.Clobberfest.Web.Areas.Accounts.Models;

namespace Spokesoft.Clobberfest.Web.Areas.Accounts.Controllers
{
    [Area(AreaName)]
    public class ConfirmEmailController : AccountsController
    {
        [Route(ConfirmEmailRoute)]
        public IActionResult Get()
        {
            var viewModel = new ConfirmEmailViewModel();
            return View(ViewPath("ConfirmEmail.cshtml"), viewModel);
        }
    }
}