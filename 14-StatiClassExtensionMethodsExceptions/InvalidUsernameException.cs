using System;

public class InvalidUsernameException : Exception
{
    public InvalidUsernameException()
        : base("Username is invalid. It cannot be empty or shorter than 3 characters.") { }

    public InvalidUsernameException(string message)
        : base(message) { }
}

