namespace CarStore.Domain.Models.Cars.ValueObjects
{
    public readonly record struct Equipment
    {
        public IReadOnlyCollection<string> CarEquipment { get; init; }

        public Equipment(IEnumerable<string> carEquipment)
        {
            if (carEquipment.Any())
                CarEquipment = new List<string>(carEquipment);
            else
                CarEquipment = new List<string>();
        }
    }
}
