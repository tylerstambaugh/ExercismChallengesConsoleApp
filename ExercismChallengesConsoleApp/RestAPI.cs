using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Reflection.Metadata;

public class RestApi
{
   
    public class User
    {
        public string name { get; set; }
        public Dictionary<string, decimal> owes { get; set; } = new Dictionary<string, decimal>();
        public Dictionary<string, decimal> owed_by { get; set; } = new Dictionary<string, decimal>();
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

            return Get("/users", JsonSerializer.Serialize(usersPayload)); 
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

