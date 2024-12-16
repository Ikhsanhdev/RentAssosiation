using RentAssosiasi.Interfaces;

namespace RentAssosiasi.Repositories
{
  public class UnitOfWorkRepository : IUnitOfWorkRepository
  {
    public UnitOfWorkRepository(
      IUserRepository userRepository
    )
    {
      User = userRepository;
    }

    public IUserRepository User { get; }
  }
}
