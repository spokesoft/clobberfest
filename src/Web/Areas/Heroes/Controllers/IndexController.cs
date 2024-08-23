using Microsoft.AspNetCore.Mvc;
using Spokesoft.Clobberfest.Web.Areas.Heroes.Models;

namespace Spokesoft.Clobberfest.Web.Areas.Heroes.Controllers
{
    [Area(AreaName)]
    public class IndexController : HeroesController
    {
        [Route(IndexRoute)]
        public IActionResult Get()
        {
            var viewModel = new IndexViewModel();
            return View(ViewPath("Index.cshtml"), viewModel);
        }
    }
}