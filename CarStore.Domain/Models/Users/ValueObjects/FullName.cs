using CarStore.Domain.Exceptions;
using CarStore.Domain.Models.Shared.Base;

namespace CarStore.Domain.Models.Users.ValueObjects
{
    public readonly record struct FullName
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }

        public FullName(string firstName, string lastName)
        {
            if (string.IsNullOrEmpty(firstName))
                throw new InvalidFullNameException("First name cannot be empty");
            if (firstName.Length is < 2 or > 100)
                throw new InvalidFullNameException("First name length must be longer than 2 and shorter than 100");

            if (string.IsNullOrEmpty(lastName))
                throw new InvalidFullNameException("Last name cannot be empty");
            if (lastName.Length is < 2 or > 100)
                throw new InvalidFullNameException("Last name length must be longer than 2 and shorter than 100");

            FirstName = firstName;
            LastName = lastName;
        }
    }
}
