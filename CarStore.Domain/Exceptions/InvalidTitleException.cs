namespace CarStore.Domain.Exceptions
{
    internal sealed class InvalidTitleException : Exception
    {
        public InvalidTitleException(string message) : base(message) { }
    }
}
