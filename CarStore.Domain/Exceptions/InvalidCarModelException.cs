namespace CarStore.Domain.Exceptions
{
    internal sealed class InvalidCarModelException : Exception
    {
        public InvalidCarModelException(string message) : base(message) { }
    }
}
