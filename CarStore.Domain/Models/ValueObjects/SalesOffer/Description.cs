using CarStore.Domain.Exceptions;

namespace CarStore.Domain.Models.ValueObjects.SalesOffer
{
    internal sealed class Description : ValueObject<Description>
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
