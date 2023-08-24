namespace CarStore.Domain.Exceptions
{
    public sealed class InvalidTuningException : Exception
    {
        public InvalidTuningException(string message) : base(message) { }
    }
}
