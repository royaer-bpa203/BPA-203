using System;

public class InvalidPasswordException : Exception
{
    public InvalidPasswordException()
        : base("Password is invalid. It cannot be empty or shorter than 6 characters.") { }

    public InvalidPasswordException(string message)
        : base(message) { }
}
