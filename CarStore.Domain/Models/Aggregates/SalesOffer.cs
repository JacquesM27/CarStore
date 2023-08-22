using CarStore.Domain.Models.ValueObjects.SalesOffer;
using CarStore.Domain.Models.ValueObjects.Shared;

namespace CarStore.Domain.Models.Aggregates
{
    internal sealed class SalesOffer : AggregateRoot<SalesOffer>
    {
        public string AuthorId { get; init; }
        public string CarId { get; init; }
        public Address Address { get; init; }
        public Phone Phone { get; init; }
        public Email Email { get; init; }
        public Description Description { get; init; }
        public Price Price { get; init; }
        public Price OfferPrice { get; init; }
        public State State { get; init; }
    }
}
