namespace CarStore.Domain.Exceptions
{
    public sealed class InvalidAddressException : Exception
    {
        public InvalidAddressException(string message) : base(message) { }
    }
}
