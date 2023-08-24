using CarStore.Domain.Enum;
using CarStore.Domain.Exceptions;
using CarStore.Domain.Models.Shared.Base;

namespace CarStore.Domain.Models.SalesOffers.ValueObjects
{
    public sealed class Price : ValueObject<Price>
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

        protected override IEnumerable<object> GetAllProperties()
        {
            yield return Value;
            yield return Currency;
        }
    }
}
