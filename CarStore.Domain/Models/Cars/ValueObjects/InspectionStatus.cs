using CarStore.Domain.Exceptions;
using CarStore.Domain.Models.Shared.Base;

namespace CarStore.Domain.Models.Cars.ValueObjects
{
    public sealed class InspectionStatus : ValueObject<InspectionStatus>
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
