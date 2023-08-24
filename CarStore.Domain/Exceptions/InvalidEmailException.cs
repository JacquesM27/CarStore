namespace CarStore.Domain.Exceptions
{
    public sealed class InvalidEmailException : Exception
    {
        public InvalidEmailException(string message) : base(message) { }
    }
}
