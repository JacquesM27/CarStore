using CarStore.Domain.Exceptions;

namespace CarStore.Domain.Models.ValueObjects.SalesOffer
{
    public sealed class Title : ValueObject<Title>
    {
        public string Value { get; init; }

        public Title(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new InvalidTitleException("Title cannot be empty!");

            Value = value;
        }

        protected override IEnumerable<object> GetAllProperties()
        {
            yield return Value;
        }
    }
}
