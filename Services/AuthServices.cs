
using RentAssosiasi.Interfaces;
using RentAssosiasi.Models;
using RentAssosiasi.Models.Auth;
using RentAssosiasi.Models.Customs;

namespace RentAssosiasi.Services
{
  public interface IAuthService
  {
    Task<ResponseWrapper> VerifyLogin(Login request);
  }

  public class AuthService : IAuthService
  {
    private readonly IUnitOfWorkRepository _unitOfWorkRepository;
    public AuthService(IUnitOfWorkRepository unitOfWorkRepository)
    {
      _unitOfWorkRepository = unitOfWorkRepository;
    }

    public async Task<ResponseWrapper> VerifyLogin(Login request)
    {
      ResponseWrapper response = new();

      try
      {
        User? user = await _unitOfWorkRepository.User.GetByUsernameAsync(request.Username);

        /* If user is not exsist */
        if (user == null)
        {
          response.Code = 400;
          response.Message = "User is not registerd";
          return response;
        }

        /* Verified User Password */
        bool verifyPassword = BCrypt.Net.BCrypt.Verify(request.Password, user.Password);
        if (!verifyPassword)
        {
          response.Code = 400;
          response.Message = "Username or password is wrong";
          return response;
        }

        /* Update kolom last login */
        await _unitOfWorkRepository.User.UpdateLastLoginAsync(user.Id);

        response.Code = 200;
        response.Message = "Login is success";
        response.Response = user;
        return response;
      }
      catch (System.Exception)
      {
        response.Code = 500;
        response.Message = "Login Error";
      }

      return response;
    }
  }
}