using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RentAssosiasi.Models;

namespace RentAssosiasi.Controllers;

public class FormsController : Controller
{
  public IActionResult BasicInputs() => View();
  public IActionResult InputGroups() => View();
}
