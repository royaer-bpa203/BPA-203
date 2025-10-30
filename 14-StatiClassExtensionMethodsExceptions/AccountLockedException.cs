using System;

public class AccountLockedException : Exception
{
    public AccountLockedException()
        : base("Account has been locked due to too many failed login attempts.") { }
}
