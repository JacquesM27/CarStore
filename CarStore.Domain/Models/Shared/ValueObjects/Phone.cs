using CarStore.Domain.Exceptions;
using System.Text.RegularExpressions;

namespace CarStore.Domain.Models.Shared.ValueObjects
{
    public readonly record struct Phone
    {
        public string Number { get; init; }

        public Phone(string phone)
        {
            if (string.IsNullOrEmpty(phone))
                throw new InvalidPhoneNumberException("Phone number cannot be empty.");

            if (phone.Length is < 2 or > 100)
                throw new InvalidPhoneNumberException("Phone number length must be longer than 2 and shorter than 100.");

            string cleanedPhoneNumber = Regex.Replace(phone, @"[\s\-()+]", "");
            if (!cleanedPhoneNumber.All(char.IsDigit))
                throw new InvalidPhoneNumberException($"Phone number contains incorrect characters.");

            Number = phone;
        }

        public static implicit operator Phone(string phone) => new(phone);

        public static implicit operator string(Phone phone) => phone.Number;

        public override string ToString() => Number;
    }
}
