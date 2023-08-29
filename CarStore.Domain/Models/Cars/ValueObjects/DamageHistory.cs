namespace CarStore.Domain.Models.Cars.ValueObjects
{
    public readonly record struct DamageHistory
    {
        public bool HadAccident { get; init; }
        public bool HadCollision { get; init; }

        public DamageHistory(bool hadAccident, bool hadCollision)
        {
            HadAccident = hadAccident;
            HadCollision = hadCollision;
        }
    }
}
