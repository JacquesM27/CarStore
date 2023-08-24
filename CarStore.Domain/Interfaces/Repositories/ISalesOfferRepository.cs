using CarStore.Domain.Interfaces.Repositories.Base;
using CarStore.Domain.Models.SalesOffers;

namespace CarStore.Domain.Interfaces.Repositories
{
    public interface ISalesOfferRepository<TId> : IRepository<SalesOffer<TId>, TId>
        where TId : notnull
    {
    }
}
