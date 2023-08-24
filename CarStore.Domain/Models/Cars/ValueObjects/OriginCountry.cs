using CarStore.Domain.Enum;
using CarStore.Domain.Models.Shared.Base;

namespace CarStore.Domain.Models.Cars.ValueObjects
{
    public sealed class OriginCountry : ValueObject<OriginCountry>
    {
        public string Country { get; init; }
        public SteeringwheelSite SteeringwheelSite { get; init; }

        public OriginCountry(string country, SteeringwheelSite steeringwheelSite)
        {
            Country = country;
            SteeringwheelSite = steeringwheelSite;
        }

        protected override IEnumerable<object> GetAllProperties()
        {
            yield return Country;
            yield return SteeringwheelSite;
        }
    }
}
