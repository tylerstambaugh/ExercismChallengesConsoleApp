//main console app


using ExercismChallengesConsoleApp;

var sut = new Allergies(257);

Console.WriteLine("The list:");
foreach(var item in sut.List())
{
   Console.WriteLine($"{item} {((int)item)}");
}

Console.ReadLine();