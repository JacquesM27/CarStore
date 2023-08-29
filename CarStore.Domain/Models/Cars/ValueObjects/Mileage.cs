using CarStore.Domain.Enum;

namespace CarStore.Domain.Models.Cars.ValueObjects
{
    public readonly record struct Mileage
    {
        public uint Value { get; init; }
        public RangeUnit RangeUnit { get; init; }

        public Mileage(uint value, RangeUnit rangeUnit)
        {
            Value = value;
            RangeUnit = rangeUnit;
        }
    }
}
