namespace CarStore.Domain.Exceptions
{
    internal sealed class InvalidProductionDateException : Exception
    {
        public InvalidProductionDateException(string message) : base(message) { }
    }
}
