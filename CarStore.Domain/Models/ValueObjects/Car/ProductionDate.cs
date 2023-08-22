using CarStore.Domain.Exceptions;

namespace CarStore.Domain.Models.ValueObjects.Car
{
    internal sealed class ProductionDate : ValueObject<ProductionDate>
    {
        public int Year { get; init; }

        public ProductionDate(int year)
        {
            int maximumYear = DateTime.Now.Year + 1;
            if (year < 1885 || year > maximumYear)
                throw new InvalidProductionDateException($"Production year must be between 1885 and {maximumYear}");

            Year = year;
        }

        protected override IEnumerable<object> GetAllProperties()
        {
            yield return Year;
        }
    }
}
