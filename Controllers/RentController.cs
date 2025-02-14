using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RentAssosiasi.Models;

namespace RentAssosiasi.Controllers;

public class RentController : Controller
{
    private readonly ILogger<RentController> _logger;

    public RentController(ILogger<RentController> logger)
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