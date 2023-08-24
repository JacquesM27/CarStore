namespace CarStore.Domain.Exceptions
{
    public sealed class InvalidDescriptionException : Exception
    {
        public InvalidDescriptionException(string message) : base(message) { }
    }
}
