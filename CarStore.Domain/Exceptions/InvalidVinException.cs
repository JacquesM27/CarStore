namespace CarStore.Domain.Exceptions
{
    public sealed class InvalidVinException : Exception
    {
        public InvalidVinException(string message) : base(message) { }
    }
}
