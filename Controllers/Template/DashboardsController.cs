using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RentAssosiasi.Models;

namespace RentAssosiasi.Controllers;

public class DashboardsController : Controller
{
  public IActionResult Index() => View();
}
