using CarStore.Domain.Exceptions;

namespace CarStore.Domain.Models.Cars.ValueObjects
{
    public readonly record struct InsuranceStatus
    {
        public string InsurerName { get; init; }
        public DateOnly EndDate { get; init; }

        public InsuranceStatus(string insurerName, DateOnly endDate)
        {
            if (string.IsNullOrEmpty(insurerName))
                throw new InvalidInsuranceStatusException("Insurer name cannot be empty");
            if (endDate < DateOnly.FromDateTime(DateTime.Now))
                throw new InvalidInsuranceStatusException("Insurance cannot be expired");

            InsurerName = insurerName;
            EndDate = endDate;
        }
    }
}
