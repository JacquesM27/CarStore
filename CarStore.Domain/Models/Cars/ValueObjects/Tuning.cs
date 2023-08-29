using CarStore.Domain.Exceptions;

namespace CarStore.Domain.Models.Cars.ValueObjects
{
    public readonly record struct Tuning
    {
        public bool Tuned { get; init; }
        public List<string> Mods { get; init; }

        public Tuning(List<string> mods)
        {
            if (!mods.Any())
                throw new InvalidTuningException("Your car is tuned only if it has some mods.");

            Tuned = true;
            Mods = mods;
        }
    }
}
