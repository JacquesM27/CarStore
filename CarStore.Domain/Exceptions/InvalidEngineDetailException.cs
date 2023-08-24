namespace CarStore.Domain.Exceptions
{
    public sealed class InvalidEngineDetailException : Exception
    {
        public InvalidEngineDetailException(string message) : base(message) { }
    }
}
