using CarStore.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore.Domain.Models.ValueObjects.Shared
{
    public sealed class Address : ValueObject<Address>
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

        protected override IEnumerable<object> GetAllProperties()
        {
            yield return Country;
            yield return Region; 
            yield return City;
        }
    }
}
