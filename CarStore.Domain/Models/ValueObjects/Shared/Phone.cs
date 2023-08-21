using CarStore.Domain.Exceptions;
using System.Text.RegularExpressions;

namespace CarStore.Domain.Models.ValueObjects.Shared
{
    internal sealed class Phone : ValueObject<Phone>
    {
        public string Number { get; init; }

        public Phone(string phone)
        {
            if (string.IsNullOrEmpty(phone))
                throw new InvalidPhoneNumberException("Phone number cannot be empty.");

            if(phone.Length is < 2 or > 100)
                throw new InvalidPhoneNumberException("Phone number length must be longer than 2 and shorter than 100.");

            string cleanedPhoneNumber = Regex.Replace(phone, @"[\s\-()+]", "");
            if (!cleanedPhoneNumber.All(char.IsDigit))
                throw new InvalidPhoneNumberException($"Phone number contains incorrect characters.");

            Number = phone;
        }

        protected override IEnumerable<object> GetAllProperties()
        {
            throw new NotImplementedException();
        }
    }
}
