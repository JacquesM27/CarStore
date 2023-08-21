namespace CarStore.Domain.Exceptions
{
    internal sealed class InvalidPhoneNumberException : Exception
    {
        public InvalidPhoneNumberException(string message) : base(message) { }  
    }
}
