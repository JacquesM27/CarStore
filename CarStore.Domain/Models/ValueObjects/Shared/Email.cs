using CarStore.Domain.Exceptions;
using System.ComponentModel.DataAnnotations;

namespace CarStore.Domain.Models.ValueObjects.Shared
{
    internal sealed class Email : ValueObject<Email>
    {
        public string EmailAddress { get; init; }

        public Email(string emailAddress)
        {
            if (string.IsNullOrEmpty(emailAddress))
                throw new InvalidEmailException("Email cannot be empty");
            if (!new EmailAddressAttribute().IsValid(emailAddress))
                throw new InvalidEmailException($"The provided value {emailAddress} is not an email address");

            EmailAddress = emailAddress;
        }

        public static implicit operator Email(string value) => new(value);

        public static implicit operator string(Email value) => value.EmailAddress;

        public override string ToString() => EmailAddress;

        protected override IEnumerable<object> GetAllProperties()
        {
            yield return EmailAddress;
        }
    }
}
