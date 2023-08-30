using CarStore.Domain.Exceptions;

namespace CarStore.Domain.Models.SalesOffers.ValueObjects
{
    public readonly record struct Description
    {
        public string Value { get; init; }

        public Description(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new InvalidDescriptionException("Description cannot be empty.");
            if(value.Length > 10000)
                throw new InvalidDescriptionException("Description cannot be longer than 10000 characters.");

            Value = value;
        }

        public static implicit operator Description(string value) => new(value);

        public static implicit operator string(Description description) => description.Value;

        public override string ToString() => Value;
    }
}
