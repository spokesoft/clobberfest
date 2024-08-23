using Microsoft.AspNetCore.Mvc;
using Spokesoft.Clobberfest.Web.Areas.Heroes.Models;

namespace Spokesoft.Clobberfest.Web.Areas.Heroes.Controllers
{
    [Area(AreaName)]
    public class CreateController : HeroesController
    {
        [Route(CreateRoute)]
        public IActionResult Get()
        {
            var viewModel = new CreateViewModel();
            return View(ViewPath("Create.cshtml"), viewModel);
        }
    }
}