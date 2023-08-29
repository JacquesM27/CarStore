namespace CarStore.Domain.Models.Cars.ValueObjects
{
    public readonly record struct DamageStatus
    {
        public bool CurrentlyDamaged { get; init; }
        public string DamageDescription { get; init; }

        public DamageStatus(bool currentlyDamaged, string damageDescription)
        {
            CurrentlyDamaged = currentlyDamaged;
            DamageDescription = damageDescription;
        }
    }
}
