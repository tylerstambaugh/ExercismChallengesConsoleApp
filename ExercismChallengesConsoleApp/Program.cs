//main console app


using ExercismChallengesConsoleApp;


var url = "/iou";
var payload = "{\"lender\":\"Adam\",\"borrower\":\"Bob\",\"amount\":3}";
var database = "[{\"name\":\"Adam\",\"owes\":{},\"owed_by\":{},\"balance\":0},{\"name\":\"Bob\",\"owes\":{},\"owed_by\":{},\"balance\":0}]";
var sut = new RestApi(database);
var actual = sut.Post(url, payload);


Console.WriteLine(actual);  
Console.ReadLine();