using CarStore.Domain.Exceptions;
using System.Text.RegularExpressions;

namespace CarStore.Domain.Models.Cars.ValueObjects
{
    public readonly record struct VIN
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

        public static implicit operator string(VIN vin) => vin.Value;

        public static implicit operator VIN(string vin) => new(vin);

        public override string ToString() => Value;
    }
}
