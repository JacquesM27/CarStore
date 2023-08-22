namespace CarStore.Domain.Exceptions
{
    internal sealed class InvalidPriceException : Exception
    {
        public InvalidPriceException(string message) : base(message) { }
    }
}
