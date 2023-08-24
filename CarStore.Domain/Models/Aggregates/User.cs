using CarStore.Domain.Models.ValueObjects.Shared;
using CarStore.Domain.Models.ValueObjects.User;

namespace CarStore.Domain.Models.Aggregates
{
    public sealed class User<T> : AggregateRoot<T> 
        where T : notnull
    {
        public FullName FullName { get; init; }
        public Email Email { get; init; }
        public Password Password { get; init; }
        public IEnumerable<Address> Addresses { get; init; }
        public Phone Phone { get; init; }

        public User(T id, FullName fullName, Email email, Password password, IEnumerable<Address> addresses, Phone phone)
            : base(id)
        {
            FullName = fullName;
            Email = email;
            Password = password;
            Addresses = addresses;
            Phone = phone;
        }
    }
}
