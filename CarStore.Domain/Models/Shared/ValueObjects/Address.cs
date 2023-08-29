using CarStore.Domain.Exceptions;

namespace CarStore.Domain.Models.Shared.ValueObjects
{
    public readonly record struct Address
    {
        public string Country { get; init; }
        public string Region { get; init; }
        public string City { get; init; }

        public Address(string country, string region, string city)
        {
            if (string.IsNullOrEmpty(country))
                throw new InvalidAddressException("Country cannot be empty.");
            if (string.IsNullOrEmpty(region))
                throw new InvalidAddressException("Region cannot be empty.");
            if (string.IsNullOrEmpty(city))
                throw new InvalidAddressException("City cannot be empty.");

            Country = country;
            Region = region;
            City = city;
        }
    }
}
