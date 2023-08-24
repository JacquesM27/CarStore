using CarStore.Domain.Exceptions;
using CarStore.Domain.Models.Shared.Base;

namespace CarStore.Domain.Models.Cars.ValueObjects
{
    public sealed class EngineDetail : ValueObject<EngineDetail>
    {
        public double Capacity { get; init; }
        public double HorsePower { get; init; }
        public double Torque { get; init; }

        public EngineDetail(double capacity, double horsePower, double torque)
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
        }

        protected override IEnumerable<object> GetAllProperties()
        {
            yield return Capacity;
            yield return HorsePower;
            yield return Torque;
        }
    }
}
