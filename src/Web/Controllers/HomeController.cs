using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Spokesoft.Clobberfest.Web.Models;

namespace Spokesoft.Clobberfest.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var viewModel = new IndexViewModel();
        return View(viewModel);
    }

    [Route("/about")]
    public IActionResult About()
    {
        var viewModel = new AboutViewModel();
        return View(viewModel);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
