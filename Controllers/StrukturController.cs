using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RentAssosiasi.Models;

namespace RentAssosiasi.Controllers;

public class StrukturController : Controller
{
    private readonly ILogger<StrukturController> _logger;

    public StrukturController(ILogger<StrukturController> logger)
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
