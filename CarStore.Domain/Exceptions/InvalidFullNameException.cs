namespace CarStore.Domain.Exceptions
{
    public sealed class InvalidFullNameException : Exception
    {
        public InvalidFullNameException(string message) : base(message) { }
    }
}
