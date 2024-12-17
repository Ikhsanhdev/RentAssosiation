using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RentAssosiasi.Models;

namespace RentAssosiasi.Controllers;

public class IconsController : Controller
{
  public IActionResult Boxicons() => View();
}
