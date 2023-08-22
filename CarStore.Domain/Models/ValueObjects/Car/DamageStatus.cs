namespace CarStore.Domain.Models.ValueObjects.Car
{
    internal sealed class DamageStatus : ValueObject<DamageStatus>
    {
        public bool CurrentlyDamaged { get; init; }
        public string DamageDescription { get; init; }

        public DamageStatus(bool currentlyDamaged, string damageDescription)
        {
            CurrentlyDamaged = currentlyDamaged;
            DamageDescription = damageDescription;
        }

        protected override IEnumerable<object> GetAllProperties()
        {
            yield return CurrentlyDamaged;
            yield return DamageDescription;
        }
    }
}
