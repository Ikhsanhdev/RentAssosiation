using RentAssosiasi.Repositories;

namespace RentAssosiasi.Interfaces
{
  public interface IUnitOfWorkRepository
  {
    IUserRepository User { get; }
  }
}
