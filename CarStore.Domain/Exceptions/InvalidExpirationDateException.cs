namespace CarStore.Domain.Exceptions
{
    internal sealed class InvalidExpirationDateException : Exception
    {
        public InvalidExpirationDateException(string message) : base(message) { }
    }
}
