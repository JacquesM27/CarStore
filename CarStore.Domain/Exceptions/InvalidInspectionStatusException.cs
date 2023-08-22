namespace CarStore.Domain.Exceptions
{
    internal sealed class InvalidInspectionStatusException : Exception
    {
        public InvalidInspectionStatusException(string message) : base(message) { }
    }
}
