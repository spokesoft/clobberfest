using Microsoft.AspNetCore.Mvc;
using Spokesoft.Clobberfest.Web.Areas.Heroes.Models;

namespace Spokesoft.Clobberfest.Web.Areas.Heroes.Controllers
{
    [Area(AreaName)]
    public class IndexController : HeroesController
    {
        [Route(IndexRoute)]
        public IActionResult RenderIndex() 
            => View(ViewPath("Index.cshtml"), new IndexViewModel());
    }
}