using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RentAssosiasi.Models;

namespace RentAssosiasi.Controllers;

public class CateringController : Controller
{
    private readonly ILogger<CateringController> _logger;

    public CateringController(ILogger<CateringController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Booking() {
        return View();
    }
}