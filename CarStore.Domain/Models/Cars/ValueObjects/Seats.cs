namespace CarStore.Domain.Models.Cars.ValueObjects
{
    public readonly record struct Seats
    {
        public uint Value { get; init; }

        public Seats(uint value)
        {
            Value = value;
        }

        public static implicit operator Seats(uint value) => new(value);

        public static implicit operator uint(Seats seats) => seats.Value;
    }
}
