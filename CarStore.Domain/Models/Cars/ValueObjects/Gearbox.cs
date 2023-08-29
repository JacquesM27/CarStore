using CarStore.Domain.Enum;

namespace CarStore.Domain.Models.Cars.ValueObjects
{
    public readonly record struct Gearbox
    {
        public GearboxType GetGearboxType { get; init; }

        public Gearbox(GearboxType gearboxType)
        {
            GetGearboxType = gearboxType;
        }

        public static implicit operator Gearbox(GearboxType gearboxType) => new(gearboxType);

        public static implicit operator GearboxType(Gearbox gearbox) => gearbox.GetGearboxType;
    }
}
