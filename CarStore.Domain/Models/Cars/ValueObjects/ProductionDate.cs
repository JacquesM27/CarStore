using CarStore.Domain.Exceptions;

namespace CarStore.Domain.Models.Cars.ValueObjects
{
    public readonly record struct ProductionDate
    {
        public int Year { get; init; }

        public ProductionDate(int year)
        {
            int maximumYear = DateTime.Now.Year + 1;
            if (year < 1885 || year > maximumYear)
                throw new InvalidProductionDateException($"Production year must be between 1885 and {maximumYear}");

            Year = year;
        }

        public static implicit operator ProductionDate(int year) => new(year);

        public static implicit operator int(ProductionDate productionDate) => productionDate.Year;
    }
}
