using CarStore.Domain.Models.Aggregates;

namespace CarStore.Domain.Interfaces.Repositories
{
    public interface IUserRepository<TId> : IRepository<User<TId>, TId>
        where TId : notnull
    {
    }
}
