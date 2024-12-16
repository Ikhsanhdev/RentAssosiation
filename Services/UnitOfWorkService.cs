using RentAssosiasi.Interfaces;

namespace RentAssosiasi.Services
{
  public class UnitOfWorkService : IUnitOfWorkService
  {
    public UnitOfWorkService(
      IAuthService authService
    )
    {
      Auths = authService;
    }

    public IAuthService Auths { get; }
  }
}
