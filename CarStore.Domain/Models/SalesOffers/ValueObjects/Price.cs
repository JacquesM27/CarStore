using CarStore.Domain.Enum;
using CarStore.Domain.Exceptions;

namespace CarStore.Domain.Models.SalesOffers.ValueObjects
{
    public readonly record struct Price
    {
        public decimal Value { get; init; }
        public Currency Currency { get; init; }

        public Price(decimal value, Currency currency)
        {
            if (value <= 0)
                throw new InvalidPriceException("Value cannot be less or equal zero.");

            Value = value;
            Currency = currency;
        }
    }
}
