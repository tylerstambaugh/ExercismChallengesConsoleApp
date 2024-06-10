//main console app


using ExercismChallengesConsoleApp;
using System.Text.Json;
var url = "/iou";
var payload = "{\"lender\":\"Adam\",\"borrower\":\"Bob\",\"amount\":4}";
var database = "[{\"name\":\"Adam\",\"owes\":{\"Bob\":3},\"owed_by\":{},\"balance\":-3},{\"name\":\"Bob\",\"owes\":{},\"owed_by\":{\"Adam\":3},\"balance\":3}]";
var sut = new RestApi(database);
var actual = sut.Post(url, payload);

Console.WriteLine(actual);
Console.ReadLine();