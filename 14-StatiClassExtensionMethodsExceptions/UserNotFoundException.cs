using System;

public class UserNotFoundException : Exception
{
    public UserNotFoundException()
        : base("User not found in the system.") { }

    public UserNotFoundException(string username)
        : base($"User '{username}' not found in the system.") { }
}
