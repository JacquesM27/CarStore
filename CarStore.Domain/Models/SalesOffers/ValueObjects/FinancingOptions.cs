namespace CarStore.Domain.Models.SalesOffers.ValueObjects
{
    public readonly record struct FinancingOptions
    {
        public bool Leasing { get; init; }
        public bool Invoice { get; init; }
        public bool Credit { get; init; }

        public FinancingOptions(bool leasing, bool invoice, bool credit)
        {
            Leasing = leasing;
            Invoice = invoice;
            Credit = credit;
        }
    }
}
