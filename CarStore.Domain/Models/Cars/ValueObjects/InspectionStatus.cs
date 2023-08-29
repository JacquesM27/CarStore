using CarStore.Domain.Exceptions;

namespace CarStore.Domain.Models.Cars.ValueObjects
{
    public readonly record struct InspectionStatus
    {
        public DateOnly EndDate { get; init; }

        public InspectionStatus(DateOnly endDate)
        {
            if (endDate < DateOnly.FromDateTime(DateTime.Now))
                throw new InvalidInspectionStatusException("Inspection cannot be expired");

            EndDate = endDate;
        }
    }
}
