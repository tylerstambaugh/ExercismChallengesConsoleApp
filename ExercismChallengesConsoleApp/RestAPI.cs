using System.Text.Json;
using System.Collections.Generic;

public class RestApi
{

    public class User
    {
        public string name { get; set; }
        public List<Owes> owes { get; set; }
        public List<Owed_By> owed_by { get; set; }
        public decimal balance { get; set; } = 0;

        public class Owes
        {
            public string Name { get; set; }
            public decimal Amount { get; set; }
        }

        public class Owed_By
        {
            public string Name { get; set; }
            public decimal Amount { get; set; }
        }
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
        User user = JsonSerializer.Serialize<User>(payload);

        if (url == "/add")
        {
            User userToAdd = new User
            {
                name = user.name,
            };
            _database.Add(userToAdd);
            return JsonSerializer.Serialize(userToAdd);

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

