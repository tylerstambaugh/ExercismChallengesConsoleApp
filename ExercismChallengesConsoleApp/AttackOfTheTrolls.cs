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
    Read = 1 << 1,
    Write = 1 << 2,
    Delete = 1 << 3,  
    All = 1 << 4
}

//crashed at the velodrome. Might finish this later. 

static class Permissions
{
    public static Permission Default(AccountType accountType) => accountType switch
    {
        AccountType.Guest => Permission.Read,
        AccountType.User => Permission.Read | Permission.Write,
        AccountType.Moderator => Permission.Read | Permission.Write | Permission.Delete,

    };
    public static Permission Grant(Permission current, Permission grant)
    {
        throw new NotImplementedException("Please implement the (static) Permissions.Grant() method");
    }
    public static Permission Revoke(Permission current, Permission revoke)
    {
        throw new NotImplementedException("Please implement the (static) Permissions.Revoke() method");
    }

    public static bool Check(Permission current, Permission check)
    {
        throw new NotImplementedException("Please implement the (static) Permissions.Check() method");
    }
}
