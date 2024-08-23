using Microsoft.AspNetCore.Mvc;
using Spokesoft.Clobberfest.Web.Areas.Heroes.Models;

namespace Spokesoft.Clobberfest.Web.Areas.Heroes.Controllers
{
    [Area(AreaName)]
    public class ProfileController : HeroesController
    {
        [Route(ProfileRoute)]
        public IActionResult Get()
        {
            var viewModel = new ProfileViewModel();
            return View(ViewPath("Profile.cshtml"), viewModel);
        }
    }
}