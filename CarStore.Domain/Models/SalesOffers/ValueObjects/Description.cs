using CarStore.Domain.Exceptions;
using CarStore.Domain.Models.Shared.Base;

namespace CarStore.Domain.Models.SalesOffers.ValueObjects
{
    public sealed class Description : ValueObject<Description>
    {
        public string Value { get; init; }
        public Description(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new InvalidDescriptionException("Description cannot be empty.");

            Value = value;
        }
        protected override IEnumerable<object> GetAllProperties()
        {
            yield return Value;
        }
    }
}
