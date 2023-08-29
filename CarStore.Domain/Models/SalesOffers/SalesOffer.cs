using CarStore.Domain.Models.Cars;
using CarStore.Domain.Models.SalesOffers.ValueObjects;
using CarStore.Domain.Models.Shared.Base;
using CarStore.Domain.Models.Shared.ValueObjects;
using CarStore.Domain.Models.Users;

namespace CarStore.Domain.Models.SalesOffers
{
    public sealed class SalesOffer<T> : AggregateRoot<T>
        where T : notnull
    {
        public User<T> Author { get; init; }
        public Car<T> Car { get; init; }
        public Address Address { get; init; }
        public Phone Phone { get; init; }
        public Email Email { get; init; }
        public Description Description { get; init; }
        public Price Price { get; init; }
        public Title Title { get; init; }

        public SalesOffer(T id, User<T> author, Car<T> car, Address address, Phone phone, Email email, Description description, Price price, Title title)
            : base(id)
        {
            Author = author;
            Car = car;
            Address = address;
            Phone = phone;
            Email = email;
            Description = description;
            Price = price;
            Title = title;
        }
    }
}
