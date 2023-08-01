using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System;

public class RestApi
{
   
    public class User
    {
        public string name { get; set; }
        public Dictionary<string, decimal> owes { get; set; } = new Dictionary<string, decimal>();
        public Dictionary<string, decimal> owed_by { get; set; } = new Dictionary<string, decimal>();
        public decimal? balance { get; set; } = 0;

   
    }

    public class UserPayload
    {
        public string? user { get; set; }
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
        if (url == "/users")
        {
            return JsonSerializer.Serialize(_database);
        }
        else
            return "not yet";
    }

    public string Post(string url, string payload)
    {
        UserPayload user = JsonSerializer.Deserialize<UserPayload>(payload);

        if (url == "/add")
        {
            User userToAdd = new User
            {
                name = user.user,
            };
            _database.Add(userToAdd);
            Console.WriteLine(JsonSerializer.Serialize(_database.Where(x => x.name == user.user)).ToString());
            return JsonSerializer.Serialize(_database.Where(x => x.name == user.user).First(), new JsonSerializerOptions { WriteIndented = false }); 

        }
        if (url == "/iou")
        {
            return "working on it";
        }
        else
        {
            return "later";
        }
    }
}

