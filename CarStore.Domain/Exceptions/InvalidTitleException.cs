namespace CarStore.Domain.Exceptions
{
    public sealed class InvalidTitleException : Exception
    {
        public InvalidTitleException(string message) : base(message) { }
    }
}
