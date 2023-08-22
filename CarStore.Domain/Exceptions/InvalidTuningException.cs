namespace CarStore.Domain.Exceptions
{
    internal sealed class InvalidTuningException : Exception
    {
        public InvalidTuningException(string message) : base(message) { }
    }
}
