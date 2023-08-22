using CarStore.Domain.Exceptions;

namespace CarStore.Domain.Models.ValueObjects.Car
{
    internal sealed class Tuning : ValueObject<Tuning>
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

        protected override IEnumerable<object> GetAllProperties()
        {
            yield return Tuned;
            yield return Mods;
        }
    }
}
