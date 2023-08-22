namespace CarStore.Domain.Exceptions
{
    internal sealed class InvalidInsuranceStatusException : Exception
    {
        public InvalidInsuranceStatusException(string message) : base(message) { }
    }
}
