using CarStore.Domain.Models.Shared.Base;

namespace CarStore.Domain.Models.Cars.ValueObjects
{
    public sealed class Equipment : ValueObject<Equipment>
    {
        public IEnumerable<string> CarEquipment { get; init; }
        public Equipment(IEnumerable<string> carEquipment)
        {
            if (carEquipment.Any())
                CarEquipment = carEquipment;
            else
                CarEquipment = new List<string>();
        }
        protected override IEnumerable<object> GetAllProperties()
        {
            yield return CarEquipment;
        }
    }
}
