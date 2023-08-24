using CarStore.Domain.Models.Aggregates;

namespace CarStore.Domain.Interfaces.Repositories
{
    public interface ICarRepository<TId> : IRepository<Car<TId>, TId> 
        where TId : notnull
    {
    }
}
