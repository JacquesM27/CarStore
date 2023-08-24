namespace CarStore.Domain.Exceptions
{
    public sealed class InvalidPriceException : Exception
    {
        public InvalidPriceException(string message) : base(message) { }
    }
}
