namespace CarStore.Domain.Exceptions
{
    public sealed class InvalidIdentityCardException : Exception
    {
        public InvalidIdentityCardException(string message) : base(message) { }
    }
}
