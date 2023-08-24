﻿using CarStore.Domain.Models.Aggregates;

namespace CarStore.Domain.Interfaces.Repositories
{
    public interface ISalesOfferRepository<TId> : IRepository<SalesOffer<TId>, TId>
        where TId : notnull
    {
    }
}
