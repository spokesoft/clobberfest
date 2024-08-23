using Microsoft.AspNetCore.Mvc;
using Spokesoft.Clobberfest.Web.Areas.Heroes.Models;

namespace Spokesoft.Clobberfest.Web.Areas.Heroes.Controllers
{
    [Area(AreaName)]
    public class GraveyardController : HeroesController
    {
        [Route(GraveyardRoute)]
        public IActionResult Get()
        {
            var viewModel = new GraveyardViewModel();
            return View(ViewPath("Graveyard.cshtml"), viewModel);
        }
    }
}