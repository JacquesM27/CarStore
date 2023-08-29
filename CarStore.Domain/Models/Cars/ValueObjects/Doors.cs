namespace CarStore.Domain.Models.Cars.ValueObjects
{
    public readonly record struct Doors
    {
        public uint Value { get; init; }

        public Doors(uint value)
        {
            Value = value;
        }

        public static implicit operator Doors(uint value) => new(value);
        public static implicit operator uint(Doors doors) => doors.Value;
    }
}
