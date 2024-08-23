using Microsoft.AspNetCore.Mvc;
using Spokesoft.Clobberfest.Web.Areas.Blog.Models;
using Spokesoft.Clobberfest.Web.Controllers;

namespace Spokesoft.Clobberfest.Web.Areas.Blog.Controllers
{
    public class BlogController : AppController
    {
        [Route("/blog")]
        public IActionResult Index()
        {
            var viewModel = new IndexViewModel();
            return View("~/Areas/Blog/Views/Index.cshtml", viewModel);
        }

        [Route("/blog/{id}")]
        public IActionResult Entry(long id)
        {
            var viewModel = new EntryViewModel();
            return View("~/Areas/Blog/Views/Index.cshtml", viewModel);
        }
    }
}