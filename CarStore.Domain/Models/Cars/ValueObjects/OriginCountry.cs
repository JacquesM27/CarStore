using CarStore.Domain.Enum;

namespace CarStore.Domain.Models.Cars.ValueObjects
{
    public readonly record struct OriginCountry
    {
        public string Country { get; init; }
        public SteeringwheelSite SteeringwheelSite { get; init; }

        public OriginCountry(string country, SteeringwheelSite steeringwheelSite)
        {
            Country = country;
            SteeringwheelSite = steeringwheelSite;
        }
    }
}
