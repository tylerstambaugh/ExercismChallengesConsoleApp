﻿using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Reflection.Metadata;

public class RestApi
{
   
    public class User
    {
        public string name { get; set; }
        public SortedDictionary<string, decimal> owes { get; set; } = new SortedDictionary<string, decimal>();
        public SortedDictionary<string, decimal> owed_by { get; set; } = new SortedDictionary<string, decimal>();
        public decimal? balance { get; set; } = 0;   
    }

    public class UsersPayload
    {
        public UsersPayload()
        {
            
        }
        public List<string> users { get; set; }
    }

    public class UserPayload
    {
        public string user { get; set; }
    }

    public class LenderPayload
    {
        public string lender { get; set; }
        public string borrower { get; set; }
        public decimal amount { get; set; }
    }

    private List<User> _database = new List<User>();

    public RestApi(string database)
    {
        var users = JsonSerializer.Deserialize<List<User>>(database);
        foreach (var user in users)
        {
            _database.Add(user);
        }
    }

    public string Get(string url, string payload = null)
    {
        if (url == "/users" && payload != null)
        {
            var userList = JsonSerializer.Deserialize<UsersPayload>(payload);
            var userNameToFind = userList.users[0];
            var returnUser = _database.Where(x => x.name == userNameToFind);
            return JsonSerializer.Serialize(returnUser);
        }
        else
            return JsonSerializer.Serialize(_database.OrderBy(x => x.name));
    }

    public string Post(string url, string payload)
    {

        if (url == "/add")
        {
        var user = JsonSerializer.Deserialize<UserPayload>(payload);
            User userToAdd = new User
            {
                name = user.user,
            };
            _database.Add(userToAdd);

            var usersPayload = new UsersPayload
            {
                users = new List<string> { user.user }
            };

            return JsonSerializer.Serialize(userToAdd); 
        }

        if (url == "/iou")
        {
           var entry = JsonSerializer.Deserialize<LenderPayload>(payload);
            var lender = _database.Where(x => x.name == entry.lender).First();
            var borrower = _database.Where(x => x.name == entry.borrower).First();

            //update lender db record
            if (lender.owed_by.TryGetValue(borrower.name, out decimal owesAmt))
            {
                lender.owed_by[borrower.name] = owesAmt + entry.amount;
            }
            else if(lender.owes.TryGetValue(borrower.name, out decimal owedAmt))
            {
                lender.owes[borrower.name] = owedAmt - entry.amount;
                if (lender.owes[borrower.name] == 0)
                {
                    lender.owes.Remove(borrower.name);
                    borrower.owed_by.Remove(lender.name);
                    lender.balance += entry.amount;
                    borrower.balance -= entry.amount;
                    return JsonSerializer.Serialize(_database.Where(x => x.name == lender.name || x.name == borrower.name).OrderBy(y => y.name));

                }
                if (lender.owes[borrower.name] < 0)
                {
                    lender.owes.Remove(borrower.name);
                    lender.owed_by.Add(borrower.name, Math.Abs(owedAmt - entry.amount));
                }
            }
            else
            {
                lender.owed_by[borrower.name] = entry.amount;
            }

            lender.balance += entry.amount;

            //update lent db record
            if (borrower.owes.TryGetValue(lender.name, out decimal oweAmt))
            {
                borrower.owes[lender.name] = oweAmt + entry.amount;
            }
            else if (borrower.owed_by.TryGetValue(lender.name, out decimal owedAmt))
            {
                borrower.owed_by[lender.name] = owedAmt - entry.amount;
                if (borrower.owed_by[lender.name] == 0)
                {
                    borrower.owed_by.Remove(lender.name);
                }
                if (borrower.owed_by[lender.name] < 0)
                {
                    borrower.owed_by.Remove(lender.name);
                    borrower.owes.Add(lender.name, entry.amount - owedAmt);
                }
            }
            else
            {
                borrower.owes[lender.name] = entry.amount;
            }
           //borrower.owes[entry.lender] = borrower.owes[entry.lender] -= entry.amount;
            borrower.balance -= entry.amount;

            //return user list
            return JsonSerializer.Serialize(_database.Where(x => x.name == lender.name || x.name == borrower.name).OrderBy(y => y.name));
        }
        else
        {
            return "later";
        }
    }
}

