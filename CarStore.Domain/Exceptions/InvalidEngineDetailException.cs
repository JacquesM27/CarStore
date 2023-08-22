namespace CarStore.Domain.Exceptions
{
    internal sealed class InvalidEngineDetailException : Exception
    {
        public InvalidEngineDetailException(string message) : base(message) { }
    }
}
