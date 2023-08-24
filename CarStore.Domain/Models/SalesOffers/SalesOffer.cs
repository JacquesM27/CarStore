using CarStore.Domain.Models.SalesOffers.ValueObjects;
using CarStore.Domain.Models.Shared.Base;
using CarStore.Domain.Models.Shared.ValueObjects;

namespace CarStore.Domain.Models.SalesOffers
{
    public sealed class SalesOffer<T> : AggregateRoot<T>
        where T : notnull
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
        public Title Title { get; init; }

        public SalesOffer(T id, string authorId, string carId, Address address, Phone phone, Email email, Description description, Price price, Price offerPrice, State state, Title title)
            : base(id)
        {
            AuthorId = authorId;
            CarId = carId;
            Address = address;
            Phone = phone;
            Email = email;
            Description = description;
            Price = price;
            OfferPrice = offerPrice;
            State = state;
            Title = title;
        }
    }
}
