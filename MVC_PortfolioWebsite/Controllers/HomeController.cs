using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_PortfolioWebsite.Models;

namespace MVC_PortfolioWebsite.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult AboutMe()
    {
        return View();
    }

    public IActionResult Connect()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

