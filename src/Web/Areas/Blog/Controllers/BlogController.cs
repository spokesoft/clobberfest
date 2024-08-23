using Microsoft.AspNetCore.Mvc;
using Spokesoft.Clobberfest.Web.Controllers;

namespace Spokesoft.Clobberfest.Web.Areas.Blog.Controllers
{
    public class BlogController : AppController
    {
        [Route("/blog")]
        public IActionResult Index()
        {
            return View("~/Areas/Blog/Views/Index.cshtml");
        }
    }
}