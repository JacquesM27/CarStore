using CarStore.Domain.Exceptions;
using System.Text.RegularExpressions;

namespace CarStore.Domain.Models.SalesOffers.ValueObjects
{
    public readonly record struct IdentityCard
    {
        public string PESEL { get; init; }
        public string NumberAndSeries { get; init; }
        public string IssuingAuthority { get; init; }

        public IdentityCard(string pESEL, string numberAndSeries, string issuingAuthority)
        {
            if (string.IsNullOrEmpty(pESEL))
                throw new InvalidIdentityCardException("PESEL cannot be empty");
            if (!IsValidPesel(pESEL))
                throw new InvalidIdentityCardException("PESEL is invalid");
            if (string.IsNullOrEmpty(numberAndSeries))
                throw new InvalidIdentityCardException("NumberAndSeries cannot be empty");
            if (!Regex.IsMatch(numberAndSeries, @"^[a-zA-Z]{3}[\s]{0,1}\d{6}$"))
                throw new InvalidIdentityCardException("NumberAndSeries is invalid");
            if (string.IsNullOrEmpty(issuingAuthority))
                throw new InvalidIdentityCardException("IssuingAuthority cannot be empty");
            

            PESEL = pESEL;
            NumberAndSeries = numberAndSeries;
            IssuingAuthority = issuingAuthority;
        }

        private bool IsValidPesel(string pesel)
        {
            if (pesel.Length != 11 || !pesel.All(char.IsDigit))
                return false;

            int year = int.Parse(pesel.Substring(0, 2));
            int month = int.Parse(pesel.Substring(2, 2));
            int day = int.Parse(pesel.Substring(4, 2));

            // Correct date of birth for those born after 2000
            switch (month)
            {
                case >= 1 and <= 12:
                    year += 1900;
                    break;
                case >= 21 and <= 32:
                    year += 2000;
                    month -= 20;
                    break;
                case >= 41 and <= 52:
                    year += 2100;
                    month -= 40;
                    break;
                case >= 61 and <= 72:
                    year += 2200;
                    month -= 60;
                    break;
                case >= 81 and <= 92:
                    year += 1800;
                    month -= 80;
                    break;
                default:
                    return false;
            }

            if (!DateTime.TryParse($"{year}-{month:D2}-{day:D2}", out _))
                return false;

            // Check the checksum
            int[] weights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += (pesel[i] - '0') * weights[i];
            }
            int checksum = sum % 10;

            return (10 - checksum) == (pesel[10] - '0');
        }
    }
}
