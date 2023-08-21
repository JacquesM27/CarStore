namespace CarStore.Domain.Exceptions
{
    internal sealed class InvalidAddressException : Exception
    {
        public InvalidAddressException(string message) : base(message) { }
    }
}
