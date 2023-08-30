using CarStore.Domain.Exceptions;

namespace CarStore.Domain.Models.SalesOffers.ValueObjects
{
    public readonly record struct ExpirationDate
    {
        public DateTime Value { get; init; }

        public ExpirationDate(DateTime value)
        {
            if (value < DateTime.Now.AddMonths(1))
                throw new InvalidExpirationDateException("The minimum validity period is one month.");

            Value = value;
        }

        public static implicit operator ExpirationDate(DateTime value) => new(value);

        public static implicit operator DateTime(ExpirationDate expirationDate) => expirationDate.Value;
    }
}
