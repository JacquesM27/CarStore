using CarStore.Domain.Exceptions;

namespace CarStore.Domain.Models.ValueObjects.Car
{
    internal sealed class InspectionStatus : ValueObject<InspectionStatus>
    {
        public DateOnly EndDate { get; init; }

        public InspectionStatus(DateOnly endDate)
        {
            if (endDate < DateOnly.FromDateTime(DateTime.Now))
                throw new InvalidInspectionStatusException("Inspection cannot be expired");

            EndDate = endDate;
        }

        protected override IEnumerable<object> GetAllProperties()
        {
            yield return EndDate;
        }
    }
}
