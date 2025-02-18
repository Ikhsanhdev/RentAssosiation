using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RentAssosiasi.Models;

namespace RentAssosiasi.Controllers;

public class DppController : Controller
{
    private readonly ILogger<DppController> _logger;

    public DppController(ILogger<DppController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
