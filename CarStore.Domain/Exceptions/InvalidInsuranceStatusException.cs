namespace CarStore.Domain.Exceptions
{
    public sealed class InvalidInsuranceStatusException : Exception
    {
        public InvalidInsuranceStatusException(string message) : base(message) { }
    }
}
