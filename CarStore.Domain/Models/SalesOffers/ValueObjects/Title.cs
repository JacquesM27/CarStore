using CarStore.Domain.Exceptions;

namespace CarStore.Domain.Models.SalesOffers.ValueObjects
{
    public readonly record struct Title
    {
        public string Value { get; init; }

        public Title(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new InvalidTitleException("Title cannot be empty!");

            Value = value;
        }

        public static implicit operator Title(string value) => new(value);

        public static implicit operator string(Title title) => title.Value;
    }
}
