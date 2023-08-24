using CarStore.Domain.Exceptions;
using CarStore.Domain.Models.Shared.Base;
using System.Text.RegularExpressions;

namespace CarStore.Domain.Models.Cars.ValueObjects
{
    public sealed class VIN : ValueObject<VIN>
    {
        public string Value { get; init; }

        public VIN(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new InvalidVinException("Vin cannot be empty");

            if (!Regex.IsMatch(value, @"^[A-HJ-NPR-Z0-9]{17}$"))
                throw new InvalidVinException("The value given is not a VIN.");

            Value = value;
        }

        protected override IEnumerable<object> GetAllProperties()
        {
            yield return Value;
        }
    }
}
