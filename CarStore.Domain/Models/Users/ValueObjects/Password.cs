using System.Security.Cryptography;
using System.Text;

namespace CarStore.Domain.Models.Users.ValueObjects
{
    public sealed class Password
    {
        public byte[] Hash { get; private set; }
        public byte[] Salt { get; private set; }

        public Password(string password)
        {
            using var hmac = new HMACSHA512();
            Salt = hmac.Key;
            Hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        }

        internal bool VerifyPassword(string password)
        {
            using var hmac = new HMACSHA512(Salt);
            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            var result = computedHash.SequenceEqual(Hash);
            return result;
        }
    }
}
