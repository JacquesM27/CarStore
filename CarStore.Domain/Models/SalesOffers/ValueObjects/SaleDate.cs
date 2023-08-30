namespace CarStore.Domain.Models.SalesOffers.ValueObjects
{
    public readonly record struct SaleDate
    {
        public DateTime Value { get; init; }

        public SaleDate(DateTime value)
        {
            Value = value;
        }

        public static implicit operator SaleDate(DateTime value) => new(value);

        public static implicit operator DateTime(SaleDate expirationDate) => expirationDate.Value;
    }
}
