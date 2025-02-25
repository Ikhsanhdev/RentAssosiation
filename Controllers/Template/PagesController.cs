using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RentAssosiasi.Models;

namespace RentAssosiasi.Controllers;

public class PagesController : Controller
{
  public IActionResult AccountSettings() => View();
  public IActionResult AccountSettingsConnections() => View();
  public IActionResult AccountSettingsNotifications() => View();
  public IActionResult MiscError() => View();
  public IActionResult MiscUnderMaintenance() => View();
}
