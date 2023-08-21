using CarStore.Domain.Exceptions;

namespace CarStore.Domain.Models.ValueObjects.SalesOffer
{
    internal sealed class CarModel : ValueObject<CarModel>
    {
        public string Manufacturer { get; init; }
        public string Model { get; init; }
        public string? Generation { get; private set; }

        public CarModel(string manufacturer, string model, string? generation)
        {
            if (string.IsNullOrEmpty(manufacturer))
                throw new InvalidCarModelException("Manufacturer cannot be empty");
            if (string.IsNullOrEmpty(model))
                throw new InvalidCarModelException("Model cannot be empty");

            Manufacturer = manufacturer;
            Model = model;
            Generation = generation;
        }

        protected override IEnumerable<object> GetAllProperties()
        {
            yield return Manufacturer;
            yield return Model;
            if(Generation is not null)
                yield return Generation;
        }
    }
}
