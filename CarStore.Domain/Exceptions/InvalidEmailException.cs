﻿namespace CarStore.Domain.Exceptions
{
    internal sealed class InvalidEmailException : Exception
    {
        public InvalidEmailException(string message) : base(message) { }
    }
}
