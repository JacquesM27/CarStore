namespace CarStore.Domain.Exceptions
{
    public sealed class InvalidCarModelException : Exception
    {
        public InvalidCarModelException(string message) : base(message) { }
    }
}
