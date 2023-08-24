namespace CarStore.Domain.Exceptions
{
    public sealed class InvalidInspectionStatusException : Exception
    {
        public InvalidInspectionStatusException(string message) : base(message) { }
    }
}
