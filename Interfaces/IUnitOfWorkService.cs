using RentAssosiasi.Services;

namespace RentAssosiasi.Interfaces
{
  public interface IUnitOfWorkService
  {
    IAuthService Auths { get; }
  }
}
