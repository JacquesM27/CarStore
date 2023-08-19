namespace CarStore.Domain.Exceptions
{
    internal class InvalidEmailException : Exception
    {
        public InvalidEmailException(string message) : base(message) { }
    }
}
