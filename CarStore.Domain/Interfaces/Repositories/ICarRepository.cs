using CarStore.Domain.Interfaces.Repositories.Base;
using CarStore.Domain.Models.Cars;

namespace CarStore.Domain.Interfaces.Repositories
{
    public interface ICarRepository<TId> : IRepository<Car<TId>, TId> 
        where TId : notnull
    {
    }
}
