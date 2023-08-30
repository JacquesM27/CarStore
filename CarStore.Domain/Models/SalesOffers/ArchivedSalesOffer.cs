using CarStore.Domain.Models.Cars;
using CarStore.Domain.Models.SalesOffers.ValueObjects;
using CarStore.Domain.Models.Shared.Base;
using CarStore.Domain.Models.Shared.ValueObjects;
using CarStore.Domain.Models.Users;

namespace CarStore.Domain.Models.SalesOffers
{
    public sealed class ArchivedSalesOffer<T> : AggregateRoot<T>
        where T : notnull
    {
        public User<T> Author { get; init; }
        public Car<T> Car { get; init; }
        public Description Description { get; init; }
        public Price Price { get; init; }
        public Title Title { get; init; }
        public Address? SellerAddress { get; init; }
        public Address? BuyerAddress { get; init; }
        public IdentityCard? SellerIdentityCard { get; init; }
        public IdentityCard? BuyerIdentityCard { get; init; }
        public SaleDate SaleDate { get; init; }

        public ArchivedSalesOffer(T id) //TODO: ctor
            : base(id)
        { }

    }
}
