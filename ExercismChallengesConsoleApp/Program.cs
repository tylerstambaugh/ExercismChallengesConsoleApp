//main console app


using ExercismChallengesConsoleApp;

//var database = "[{\"name\":\"Adam\",\"owes\":{},\"owed_by\":{},\"balance\":0},{\"name\":\"Bob\",\"owes\":{},\"owed_by\":{},\"balance\":0}]";




//var url = "/users";
//var payload = "{\"users\":[\"Bob\"]}";
//var database = "[{\"name\":\"Adam\",\"owes\":{},\"owed_by\":{},\"balance\":0},{\"name\":\"Bob\",\"owes\":{},\"owed_by\":{},\"balance\":0}]";
//var sut = new RestApi(database);
//var actual = sut.Get(url, payload);


var url = "/users";
var payload = "{\"users\":[\"Bob\"]}";
var database = "[{\"name\":\"Adam\",\"owes\":{},\"owed_by\":{},\"balance\":0},{\"name\":\"Bob\",\"owes\":{},\"owed_by\":{},\"balance\":0}]";
var sut = new RestApi(database);
var actual = sut.Get(url, payload);


Console.WriteLine(actual);  
Console.ReadLine();