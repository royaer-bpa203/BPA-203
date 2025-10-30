using System;

public class IncorrectPasswordException : Exception
{
    public int AttemptsLeft { get; }

    public IncorrectPasswordException(int attemptsLeft)
        : base($"Incorrect password. Attempts left: {attemptsLeft}")
    {
        AttemptsLeft = attemptsLeft;
    }
}
