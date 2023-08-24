namespace CarStore.Domain.Exceptions
{
    public sealed class InvalidPhoneNumberException : Exception
    {
        public InvalidPhoneNumberException(string message) : base(message) { }  
    }
}
