using CarStore.Domain.Models.ValueObjects.SalesOffer;
using CarStore.Domain.Models.ValueObjects.Shared;

namespace CarStore.Domain.Models.Aggregates
{
    internal sealed class SalesOffer : AggregateRoot<SalesOffer>
    {
        public CarModel CarModel { get; set; }
        public Address Address { get; init; }
        public Phone Phone { get; set; }

        public SalesOffer()
        {

        }
    }
}
