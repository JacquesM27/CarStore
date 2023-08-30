using CarStore.Domain.Exceptions;
using CarStore.Domain.Models.Cars;
using CarStore.Domain.Models.SalesOffers.ValueObjects;
using CarStore.Domain.Models.Shared.Base;
using CarStore.Domain.Models.Shared.ValueObjects;
using CarStore.Domain.Models.Users;

namespace CarStore.Domain.Models.SalesOffers
{
    internal class UnpaidSalesOffer<T> : AggregateRoot<T>
        where T : notnull
    {
        public User<T> Author { get; init; }
        public Car<T> Car { get; init; }
        public Address Address { get; init; }
        public Phone Phone { get; init; }
        public Email Email { get; init; }
        public Description Description { get; init; }
        public Price Price { get; init; }
        public Price PriceOfPublishOffer { get; init; }
        public Title Title { get; init; }
        public FinancingOptions FinancingOptions { get; init; }

        public UnpaidSalesOffer(T id, User<T> author, Car<T> car, Address address, Phone phone, Email email, Description description, Price price, Price priceOfPublishOffer, Title title, FinancingOptions financingOptions)
            : base(id)
        {
            Author = author;
            Car = car;
            Address = address;
            Phone = phone;
            Email = email;
            Description = description;
            Price = price;
            PriceOfPublishOffer = priceOfPublishOffer;
            Title = title;
            FinancingOptions = financingOptions;
        }

        public SalesOffer<T> PayForPublicationOffer(Price price, int paidDays)
        {
            if(price.Currency != PriceOfPublishOffer.Currency)
                throw new InvalidPriceException("Price is not equal to price of publish offer");
            if(price.Value < PriceOfPublishOffer.Value)
                throw new InvalidPriceException("Price is less than required");

            SalesOffer<T> salesOffer = new(Id, Author, Car, Address, Phone, Email, Description, Price, Title, FinancingOptions, DateTime.Now.AddDays(paidDays));
            return salesOffer;
        }
    }
}