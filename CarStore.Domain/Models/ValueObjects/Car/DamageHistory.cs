namespace CarStore.Domain.Models.ValueObjects.Car
{
    public sealed class DamageHistory : ValueObject<DamageHistory>
    {
        public bool HadAccident { get; init; }
        public bool HadCollision { get; init; }

        public DamageHistory(bool hadAccident, bool hadCollision)
        {
            HadAccident = hadAccident;
            HadCollision = hadCollision;
        }
        protected override IEnumerable<object> GetAllProperties()
        {
            yield return HadAccident;
            yield return HadCollision;
        }
    }
}
