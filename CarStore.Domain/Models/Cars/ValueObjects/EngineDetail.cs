using CarStore.Domain.Enum;
using CarStore.Domain.Exceptions;

namespace CarStore.Domain.Models.Cars.ValueObjects
{
    public readonly record struct EngineDetail
    {
        public double Capacity { get; init; }
        public double HorsePower { get; init; }
        public double Torque { get; init; }
        public FuelType FuelType { get; init; }

        public EngineDetail(double capacity, double horsePower, double torque, FuelType fuelType)
        {
            if (capacity <= 0)
                throw new InvalidEngineDetailException("Engine capacity cannot be less or equal 0");
            if (horsePower <= 0)
                throw new InvalidEngineDetailException("Horse power cannot be less or equal 0");
            if (torque <= 0)
                throw new InvalidEngineDetailException("Torque cannot be less or equal 0");

            Capacity = capacity;
            HorsePower = horsePower;
            Torque = torque;
            FuelType = fuelType;
        }
    }
}
