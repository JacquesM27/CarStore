using CarStore.Domain.Exceptions;

namespace CarStore.Domain.Models.ValueObjects
{
    internal sealed class FullName : ValueObject<FullName>
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }

        public FullName(string firstName, string lastName)
        {
            if (string.IsNullOrEmpty(firstName))
                throw new InvalidFullNameException("First name cannot be null or empty");
            if(firstName.Length is < 2 or > 100)
                throw new InvalidFullNameException("First name length must be longer than 2 and shorter than 100");

            if (string.IsNullOrEmpty(lastName))
                throw new InvalidFullNameException("Last name cannot be null or empty");
            if (lastName.Length is < 2 or > 100)
                throw new InvalidFullNameException("Last name length must be longer than 2 and shorter than 100");

            FirstName = firstName;
            LastName = lastName;
        }
        protected override IEnumerable<object> GetAllProperties()
        {
            yield return FirstName;
            yield return LastName;
        }

        public override string ToString() => $"{FirstName} {LastName}";
    }
}
