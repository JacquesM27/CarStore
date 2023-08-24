namespace CarStore.Domain.Exceptions
{
    public sealed class InvalidProductionDateException : Exception
    {
        public InvalidProductionDateException(string message) : base(message) { }
    }
}
