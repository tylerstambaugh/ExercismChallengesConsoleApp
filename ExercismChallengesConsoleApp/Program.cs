//main console app


using ExercismChallengesConsoleApp;

//var database = "[{\"name\":\"Adam\",\"owes\":{},\"owed_by\":{},\"balance\":0},{\"name\":\"Bob\",\"owes\":{},\"owed_by\":{},\"balance\":0}]";




var url = "/add";
var payload = "{\"user\":\"Adam\"}";
var database = "[]";
var sut = new RestApi(database);

sut.Post(url, payload);
Console.ReadLine();