using CarStore.Domain.Models.ValueObjects.Shared;
using CarStore.Domain.Models.ValueObjects.User;

namespace CarStore.Domain.Models.Aggregates
{
    internal class User : AggregateRoot<Entity>
    {
        public FullName FullName { get; init; }
        public Email Email { get; init; }
        public Password Password { get; init; }
        public IEnumerable<Address> Addresses { get; init; }
        public Phone Phone { get; set; }

        public User(string id, FullName fullName, Email email, Password password, IEnumerable<Address> addresses)
        {
            Id = id;
            FullName = fullName;
            Email = email;
            Password = password;
            Addresses = addresses;
        }
    }
}
