using CarStore.Domain.Exceptions;
using CarStore.Domain.Models.Shared.Base;

namespace CarStore.Domain.Models.SalesOffers.ValueObjects
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
