namespace CarStore.Domain.Exceptions
{
    internal sealed class InvalidVinException : Exception
    {
        public InvalidVinException(string message) : base(message) { }
    }
}
