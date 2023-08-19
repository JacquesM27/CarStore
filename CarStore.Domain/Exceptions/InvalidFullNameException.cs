namespace CarStore.Domain.Exceptions
{
    internal sealed class InvalidFullNameException : Exception
    {
        public InvalidFullNameException(string message) : base(message) { }
    }
}
