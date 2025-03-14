using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MandoLms.WebApp.Models;
using MandoLms.WebApp.Services;

namespace MandoLms.WebApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IClassRegistrationService _reportService;

    public HomeController(ILogger<HomeController> logger, 
        IClassRegistrationService reportService)
    {
        _logger = logger;
        _reportService = reportService;
    }

    public IActionResult Index(int? minRegistrations)
    {
        var report = _reportService.GetRegistrationReport(minRegistrations);
        return View(report);
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
