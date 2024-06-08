﻿using System;
using System.Security;

[Flags]
enum AccountType : byte
{
    Guest = Permission.Read,
    User = Permission.Read | Permission.Write,
    Moderator = Permission.Read | Permission.Write | Permission.Delete,
}

[Flags]
enum Permission : byte
{
    None = 0,
    Read = 1 << 0,
    Write = 1 << 1,
    Delete = 1 << 2,
    All = Read | Write | Delete
}


static class Permissions
{
    public static Permission Default(AccountType accountType) => accountType switch
    {
        AccountType.Guest => Permission.Read,
        AccountType.User => Permission.Read | Permission.Write,
        AccountType.Moderator => Permission.Read | Permission.Write | Permission.Delete,
        _ => Permission.None

    };
    public static Permission Grant(Permission current, Permission grant) => current | grant;

    public static Permission Revoke(Permission current, Permission revoke)
    {
        return current & ~revoke;
    }

    public static bool Check(Permission current, Permission check)
    {
        return (current & check) == check;
    }
}
