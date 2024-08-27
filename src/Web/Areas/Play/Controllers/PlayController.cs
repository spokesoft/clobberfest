using Microsoft.AspNetCore.Mvc;
using Spokesoft.Clobberfest.Web.Controllers;

namespace Spokesoft.Clobberfest.Web.Areas.Play.Controllers
{
    public class PlayController : AppController
    {
        public const string IndexRoute = "/play";
        public const string HeroSelectRoute = "/heroes";
        public const string HeroCreateRoute = "/heroes";

        [Route(IndexRoute)]
        public IActionResult Index()
        {
            return RedirectToRoute("IndexController.Index", new { area = "Heroes" });
        }
    }
}