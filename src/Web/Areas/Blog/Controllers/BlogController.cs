using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Spokesoft.Clobberfest.Data.Contexts;
using Spokesoft.Clobberfest.Web.Areas.Blog.Models;
using Spokesoft.Clobberfest.Web.Controllers;

namespace Spokesoft.Clobberfest.Web.Areas.Blog.Controllers
{
    public class BlogController(ILogger<BlogController> logger, BlogDbContext context) : AppController
    {
        public const string IndexRoute = "/blog";
        public const string ArticleRoute = "/blog/{id}";
        
        private readonly ILogger<BlogController> _logger = logger;
        private readonly BlogDbContext _context = context;

        [Route(IndexRoute)]
        public async Task<IActionResult> Index()
        {
            _logger.LogInformation("Rendering blog index page");
            var articles = await _context.Articles.ToListAsync();
            var viewModel = new IndexViewModel();
            viewModel.Articles = articles;
            return View("~/Areas/Blog/Views/Index.cshtml", viewModel);
        }

        [Route(IndexRoute + ".json")]
        public async Task<IActionResult> IndexJson()
        {
            var articles = await _context.Articles.ToListAsync();
            return Json(articles);
        }

        [Route(ArticleRoute)]
        public IActionResult Article(long id)
        {
            _logger.LogInformation("Rendering blog article page");
            var viewModel = new ArticleViewModel();
            return View("~/Areas/Blog/Views/Index.cshtml", viewModel);
        }
    }
}