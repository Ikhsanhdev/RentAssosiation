using System.Security.Claims;
using RentAssosiasi.Interfaces;
using RentAssosiasi.Models;
using RentAssosiasi.Models.Auth;
using RentAssosiasi.Models.Customs;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace RentAssosiasi.Controllers;
public class AuthController : Controller
{
  private readonly IUnitOfWorkService _unitOfWorkService;

  public AuthController(IUnitOfWorkService unitOfWorkService)
  {
    _unitOfWorkService = unitOfWorkService;
  }

  public IActionResult Login()
  {
    ClaimsPrincipal claimUser = HttpContext.User;

    if (claimUser?.Identity?.IsAuthenticated == true)
    {
      return Redirect("/");
    }
    return View();
  }

  [HttpPost]
  public async Task<IActionResult> Login(Login request)
  {
    try
    {
      ResponseWrapper response = await _unitOfWorkService.Auths.VerifyLogin(request);
      if (response.Code == 400) return BadRequest(response);
      if (response.Code == 500) return StatusCode(StatusCodes.Status500InternalServerError, response);

      User user = (User)response.Response!;
      /* Config Cookies */
      var userClaims = new List<Claim>()
        {
            new Claim("Username", user.Username!),
            new Claim("UserId", user.Id.ToString()),
            new Claim("Name", user.Name),
            new Claim("Phone", user.Phone!),
            new Claim("IPAddress", HttpContext.Connection.RemoteIpAddress?.ToString() ?? ""),
            new Claim("Email", user.Email ?? ""),
            new Claim("LastLogin", Convert.ToDateTime(user.LastLogin).ToString("yyyy-MM-dd H:mm:ss")),
        };

      CookieOptions options = new CookieOptions();
      options.Expires = DateTime.Now.AddHours(5);

      var grandmaIdentity = new ClaimsIdentity(userClaims, "AmeroroCookiesAuth");
      var userPrincipal = new ClaimsPrincipal([grandmaIdentity]);
      await HttpContext.SignInAsync("CookieAuthentication", userPrincipal);
      user.Password = "********";
      response.Response = response;

      return Ok(response);
    }
    catch (System.Exception ex)
    {
      return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
    }

  }

  public async Task<IActionResult> Logout()
  {
    foreach (var cookie in Request.Cookies.Keys) Response.Cookies.Delete(cookie);
    await HttpContext.SignOutAsync("CookieAuthentication");
    return Redirect("/");
  }
}