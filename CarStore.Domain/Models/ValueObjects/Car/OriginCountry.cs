using CarStore.Domain.Enum;

namespace CarStore.Domain.Models.ValueObjects.Car
{
    internal sealed class OriginCountry : ValueObject<OriginCountry>
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
