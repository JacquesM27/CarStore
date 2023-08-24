using CarStore.Domain.Interfaces.Repositories.Base;
using CarStore.Domain.Models.Users;

namespace CarStore.Domain.Interfaces.Repositories
{
    public interface IUserRepository<TId> : IRepository<User<TId>, TId>
        where TId : notnull
    {
    }
}
