namespace CarStore.Domain.Exceptions
{
    public sealed class InvalidExpirationDateException : Exception
    {
        public InvalidExpirationDateException(string message) : base(message) { }
    }
}
