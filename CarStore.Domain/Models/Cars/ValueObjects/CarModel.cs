using CarStore.Domain.Enum;
using CarStore.Domain.Exceptions;
using CarStore.Domain.Models.Shared.Base;

namespace CarStore.Domain.Models.Cars.ValueObjects
{
    public sealed class CarModel : ValueObject<CarModel>
    {
        public string Manufacturer { get; init; }
        public string Model { get; init; }
        public string? Generation { get; init; }
        public CarChasis CarChasis { get; init; }
        public CarModel(string manufacturer, string model, string? generation, CarChasis carChasis)
        {
            if (string.IsNullOrEmpty(manufacturer))
                throw new InvalidCarModelException("Manufacturer cannot be empty");
            if (string.IsNullOrEmpty(model))
                throw new InvalidCarModelException("Model cannot be empty");

            Manufacturer = manufacturer;
            Model = model;
            Generation = generation;
            CarChasis = carChasis;
        }

        protected override IEnumerable<object> GetAllProperties()
        {
            yield return Manufacturer;
            yield return Model;
            yield return Generation;
            yield return CarChasis;
        }
    }
}
