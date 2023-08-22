namespace CarStore.Domain.Exceptions
{
    internal sealed class InvalidDescriptionException : Exception
    {
        public InvalidDescriptionException(string message) : base(message) { }
    }
}
